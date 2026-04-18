CREATE TABLE MEMBERSHIP_PLAN (
    id            INT           IDENTITY(1,1) PRIMARY KEY,
    name          NVARCHAR(100) NOT NULL,
    price         DECIMAL(10,2) NOT NULL,
    duration_days INT           NOT NULL
);

CREATE TABLE MEMBER (
    id         INT           IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(100) NOT NULL,
    last_name  NVARCHAR(100) NOT NULL,
    email      NVARCHAR(150) NOT NULL UNIQUE,
    phone      NVARCHAR(20),
    join_date  DATE          NOT NULL DEFAULT GETDATE(),
    status     NVARCHAR(20)  NOT NULL DEFAULT 'active'
);

CREATE TABLE SUBSCRIPTION (
    id         INT          IDENTITY(1,1) PRIMARY KEY,
    member_id  INT          NOT NULL,
    plan_id    INT          NOT NULL,
    start_date DATE         NOT NULL,
    end_date   DATE         NOT NULL,
    status     NVARCHAR(20) NOT NULL DEFAULT 'active',
    FOREIGN KEY (member_id) REFERENCES MEMBER(id),
    FOREIGN KEY (plan_id)   REFERENCES MEMBERSHIP_PLAN(id)
);

CREATE TABLE TRAINER (
    id             INT           IDENTITY(1,1) PRIMARY KEY,
    first_name     NVARCHAR(100) NOT NULL,
    last_name      NVARCHAR(100) NOT NULL,
    specialization NVARCHAR(150),
    hourly_rate    DECIMAL(10,2) NOT NULL DEFAULT 0.00
);

CREATE TABLE ROOM (
    id       INT           IDENTITY(1,1) PRIMARY KEY,
    name     NVARCHAR(100) NOT NULL,
    capacity INT           NOT NULL
);

CREATE TABLE GYM_CLASS (
    id           INT           IDENTITY(1,1) PRIMARY KEY,
    name         NVARCHAR(150) NOT NULL,
    trainer_id   INT           NOT NULL,
    room_id      INT           NOT NULL,
    capacity     INT           NOT NULL,
    scheduled_at DATETIME      NOT NULL,
    FOREIGN KEY (trainer_id) REFERENCES TRAINER(id),
    FOREIGN KEY (room_id)    REFERENCES ROOM(id)
);

CREATE TABLE PT_SESSION (
    id           INT          IDENTITY(1,1) PRIMARY KEY,
    member_id    INT          NOT NULL,
    trainer_id   INT          NOT NULL,
    scheduled_at DATETIME     NOT NULL,
    status       NVARCHAR(20) NOT NULL DEFAULT 'scheduled',
    FOREIGN KEY (member_id)  REFERENCES MEMBER(id),
    FOREIGN KEY (trainer_id) REFERENCES TRAINER(id)
);

CREATE TABLE GYM_BOOKING (
    id           INT          IDENTITY(1,1) PRIMARY KEY,
    member_id    INT          NOT NULL,
    gym_class_id INT          NOT NULL,
    status       NVARCHAR(20) NOT NULL DEFAULT 'booked',
    FOREIGN KEY (member_id)    REFERENCES MEMBER(id),
    FOREIGN KEY (gym_class_id) REFERENCES GYM_CLASS(id)
);

CREATE TABLE STAFF (
    id         INT           IDENTITY(1,1) PRIMARY KEY,
    first_name NVARCHAR(100) NOT NULL,
    last_name  NVARCHAR(100) NOT NULL,
    email      NVARCHAR(150),
    phone      NVARCHAR(20),
    position   NVARCHAR(100),
    salary     DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    hire_date  DATE          NOT NULL DEFAULT GETDATE(),
    status     NVARCHAR(20)  NOT NULL DEFAULT 'active'
);

CREATE TABLE PAYMENT (
    id              INT           IDENTITY(1,1) PRIMARY KEY,
    subscription_id INT           NOT NULL,
    processed_by    INT           NOT NULL,
    amount          DECIMAL(10,2) NOT NULL,
    payment_date    DATE          NOT NULL DEFAULT GETDATE(),
    method          NVARCHAR(50)  NOT NULL,
    FOREIGN KEY (subscription_id) REFERENCES SUBSCRIPTION(id),
    FOREIGN KEY (processed_by)    REFERENCES STAFF(id)
);

CREATE TABLE EQUIPMENT (
    id      INT           IDENTITY(1,1) PRIMARY KEY,
    name    NVARCHAR(150) NOT NULL,
    type    NVARCHAR(100),
    room_id INT           NOT NULL,
    status  NVARCHAR(20)  NOT NULL DEFAULT 'operational',
    FOREIGN KEY (room_id) REFERENCES ROOM(id)
);

CREATE TABLE ADMIN (
    id            INT           IDENTITY(1,1) PRIMARY KEY,
    staff_id      INT           NOT NULL UNIQUE,
    username      NVARCHAR(100) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL,
    role          NVARCHAR(50)  NOT NULL DEFAULT 'admin',
    last_login    DATETIME,
    created_at    DATETIME      NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (staff_id) REFERENCES STAFF(id)
);

CREATE TABLE AUDIT_LOG (
    id           INT           IDENTITY(1,1) PRIMARY KEY,
    admin_id     INT           NOT NULL,
    action       NVARCHAR(100) NOT NULL,
    target_table NVARCHAR(100) NOT NULL,
    target_id    INT           NOT NULL,
    performed_at DATETIME      NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (admin_id) REFERENCES ADMIN(id)
);