CREATE TABLE MEMBERSHIP_PLAN (
    plan_id       INT           IDENTITY(1,1) PRIMARY KEY,
    name          NVARCHAR(100) NOT NULL,
    description   NVARCHAR(500),
    price         DECIMAL(10,2) NOT NULL,
    duration_days INT           NOT NULL
);

CREATE TABLE MEMBER (
    member_id               INT           IDENTITY(1,1) PRIMARY KEY,
    first_name              NVARCHAR(100) NOT NULL,
    last_name               NVARCHAR(100) NOT NULL,
    email                   NVARCHAR(150) NOT NULL UNIQUE,
    phone                   NVARCHAR(20),
    date_of_birth           DATE,
    join_date               DATE          NOT NULL DEFAULT GETDATE(),
    emergency_contact_name  NVARCHAR(200),
    emergency_contact_phone NVARCHAR(20),
    status                  NVARCHAR(20)  NOT NULL DEFAULT 'active',
    CONSTRAINT chk_member_status CHECK (status IN ('active', 'inactive', 'suspended'))
);

CREATE TABLE SUBSCRIPTION (
    subscription_id INT          IDENTITY(1,1) PRIMARY KEY,
    member_id       INT          NOT NULL,
    plan_id         INT          NOT NULL,
    start_date      DATE         NOT NULL,
    end_date        DATE         NOT NULL,
    status          NVARCHAR(20) NOT NULL DEFAULT 'active',
    CONSTRAINT chk_subscription_dates  CHECK (end_date > start_date),
    CONSTRAINT chk_subscription_status CHECK (status IN ('active', 'expired', 'cancelled')),
    CONSTRAINT fk_subscription_member          FOREIGN KEY (member_id) REFERENCES MEMBER(member_id),
    CONSTRAINT fk_subscription_membership_plan FOREIGN KEY (plan_id)   REFERENCES MEMBERSHIP_PLAN(plan_id)
);

CREATE TABLE TRAINER (
    trainer_id     INT           IDENTITY(1,1) PRIMARY KEY,
    first_name     NVARCHAR(100) NOT NULL,
    last_name      NVARCHAR(100) NOT NULL,
    email          NVARCHAR(150) NOT NULL UNIQUE,
    phone          NVARCHAR(20),
    specialization NVARCHAR(150),
    hourly_rate    DECIMAL(10,2) NOT NULL DEFAULT 0.00
);

CREATE TABLE PT_SESSION (
    pt_session_id    INT           IDENTITY(1,1) PRIMARY KEY,
    member_id        INT           NOT NULL,
    trainer_id       INT           NOT NULL,
    scheduled_at     DATETIME      NOT NULL,
    duration_minutes INT           NOT NULL DEFAULT 60,
    notes            NVARCHAR(500),
    status           NVARCHAR(20)  NOT NULL DEFAULT 'scheduled',
    CONSTRAINT chk_pt_session_status CHECK (status IN ('scheduled', 'completed', 'cancelled', 'no-show')),
    CONSTRAINT fk_pt_session_member  FOREIGN KEY (member_id)  REFERENCES MEMBER(member_id),
    CONSTRAINT fk_pt_session_trainer FOREIGN KEY (trainer_id) REFERENCES TRAINER(trainer_id)
);

CREATE TABLE ATTENDANCE (
    attendance_id INT      IDENTITY(1,1) PRIMARY KEY,
    member_id     INT      NOT NULL,
    check_in      DATETIME NOT NULL DEFAULT GETDATE(),
    check_out     DATETIME,
    CONSTRAINT chk_attendance_checkout CHECK (check_out IS NULL OR check_out > check_in),
    CONSTRAINT fk_attendance_member FOREIGN KEY (member_id) REFERENCES MEMBER(member_id)
);

CREATE TABLE LOCKER (
    locker_id     INT          IDENTITY(1,1) PRIMARY KEY,
    locker_number NVARCHAR(10) NOT NULL UNIQUE,
    member_id     INT,
    status        NVARCHAR(20) NOT NULL DEFAULT 'available',
    CONSTRAINT chk_locker_status  CHECK (status IN ('available', 'assigned', 'maintenance')),
    CONSTRAINT fk_locker_member   FOREIGN KEY (member_id) REFERENCES MEMBER(member_id)
);

CREATE TABLE STAFF (
    staff_id      INT           IDENTITY(1,1) PRIMARY KEY,
    first_name    NVARCHAR(100) NOT NULL,
    last_name     NVARCHAR(100) NOT NULL,
    email         NVARCHAR(150) NOT NULL UNIQUE,
    phone         NVARCHAR(20),
    position      NVARCHAR(100),
    username      NVARCHAR(100) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL,
    last_login    DATETIME,
    role          NVARCHAR(20)  NOT NULL DEFAULT 'staff',
    salary        DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    hire_date     DATE          NOT NULL DEFAULT GETDATE(),
    status        NVARCHAR(20)  NOT NULL DEFAULT 'active',
    CONSTRAINT chk_staff_role   CHECK (role   IN ('admin', 'staff')),
    CONSTRAINT chk_staff_status CHECK (status IN ('active', 'inactive', 'terminated'))
);

CREATE TABLE PAYMENT (
    payment_id      INT           IDENTITY(1,1) PRIMARY KEY,
    subscription_id INT           NOT NULL,
    processed_by    INT           NOT NULL,
    amount          DECIMAL(10,2) NOT NULL,
    payment_date    DATE          NOT NULL DEFAULT GETDATE(),
    method          NVARCHAR(50)  NOT NULL,
    status          NVARCHAR(20)  NOT NULL DEFAULT 'completed',
    CONSTRAINT chk_payment_method CHECK (method IN ('cash', 'credit_card', 'debit_card', 'bank_transfer', 'online')),
    CONSTRAINT chk_payment_status CHECK (status IN ('completed', 'failed', 'refunded', 'pending')),
    CONSTRAINT fk_payment_subscription FOREIGN KEY (subscription_id) REFERENCES SUBSCRIPTION(subscription_id),
    CONSTRAINT fk_payment_staff        FOREIGN KEY (processed_by)    REFERENCES STAFF(staff_id)
);

CREATE TABLE EQUIPMENT (
    equipment_id     INT           IDENTITY(1,1) PRIMARY KEY,
    name             NVARCHAR(150) NOT NULL,
    type             NVARCHAR(100),
    purchase_date    DATE,
    last_maintenance DATE,
    status           NVARCHAR(20)  NOT NULL DEFAULT 'working',
    CONSTRAINT chk_equipment_status CHECK (status IN ('working', 'broken', 'maintenance'))
);

CREATE TABLE MEMBER_PROGRESS (
    progress_id      INT           IDENTITY(1,1) PRIMARY KEY,
    member_id        INT           NOT NULL,
    recorded_date    DATE          NOT NULL DEFAULT GETDATE(),
    weight_kg        DECIMAL(5,2),
    attendance_count INT           NOT NULL DEFAULT 0,
    notes            NVARCHAR(500),
    CONSTRAINT uq_member_progress_month UNIQUE (member_id, recorded_date),
    CONSTRAINT fk_member_progress_member FOREIGN KEY (member_id) REFERENCES MEMBER(member_id)
);
