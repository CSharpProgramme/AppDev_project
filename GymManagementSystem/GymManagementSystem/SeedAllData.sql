-- ============================================================
-- SEED ALL DATA - GymManagementDB
-- Run in Visual Studio: View > SQL Server Object Explorer
--   > (localdb)\MSSQLLocalDB > GymManagementDB > New Query
-- Safe to run multiple times (uses IF NOT EXISTS checks)
-- ============================================================

DECLARE @basicId INT, @standardId INT, @premiumId INT;
DECLARE @staff1 INT, @staff2 INT;
DECLARE @trainer1 INT, @trainer2 INT, @trainer3 INT;
DECLARE @m1 INT, @m2 INT, @m3 INT, @m4 INT, @m5 INT;
DECLARE @s1 INT, @s2 INT, @s3 INT, @s4 INT, @s5 INT;

-- ============================================================
-- 1. MEMBERSHIP PLANS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM MEMBERSHIP_PLAN WHERE name = 'Basic')
    INSERT INTO MEMBERSHIP_PLAN (name, description, price, duration_days)
    VALUES ('Basic', 'Basic gym access. Weights and cardio only.', 29.99, 30);

IF NOT EXISTS (SELECT 1 FROM MEMBERSHIP_PLAN WHERE name = 'Standard')
    INSERT INTO MEMBERSHIP_PLAN (name, description, price, duration_days)
    VALUES ('Standard', 'Full gym access including group classes.', 49.99, 30);

IF NOT EXISTS (SELECT 1 FROM MEMBERSHIP_PLAN WHERE name = 'Premium')
    INSERT INTO MEMBERSHIP_PLAN (name, description, price, duration_days)
    VALUES ('Premium', 'All access plus 2 PT sessions per month.', 79.99, 30);

SET @basicId    = (SELECT plan_id FROM MEMBERSHIP_PLAN WHERE name = 'Basic');
SET @standardId = (SELECT plan_id FROM MEMBERSHIP_PLAN WHERE name = 'Standard');
SET @premiumId  = (SELECT plan_id FROM MEMBERSHIP_PLAN WHERE name = 'Premium');

-- ============================================================
-- 2. STAFF  (password is plain text — matches your Login query)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM STAFF WHERE username = 'admin')
    INSERT INTO STAFF (first_name, last_name, email, phone, position, username, password_hash, role, salary, hire_date, status)
    VALUES ('Steve', 'Admin', 'steve@gym.com', '555-0001', 'Manager', 'admin', 'admin123', 'admin', 60000, '2023-01-15', 'active');

IF NOT EXISTS (SELECT 1 FROM STAFF WHERE username = 'jsmith')
    INSERT INTO STAFF (first_name, last_name, email, phone, position, username, password_hash, role, salary, hire_date, status)
    VALUES ('James', 'Smith', 'james@gym.com', '555-0002', 'Receptionist', 'jsmith', 'pass123', 'staff', 38000, '2024-03-01', 'active');

SET @staff1 = (SELECT staff_id FROM STAFF WHERE username = 'admin');
SET @staff2 = (SELECT staff_id FROM STAFF WHERE username = 'jsmith');

-- ============================================================
-- 3. TRAINERS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM TRAINER WHERE email = 'mike.t@gym.com')
    INSERT INTO TRAINER (first_name, last_name, email, phone, specialization, hourly_rate)
    VALUES ('Mike', 'Torres', 'mike.t@gym.com', '555-1101', 'Strength & Conditioning', 45.00);

IF NOT EXISTS (SELECT 1 FROM TRAINER WHERE email = 'lisa.r@gym.com')
    INSERT INTO TRAINER (first_name, last_name, email, phone, specialization, hourly_rate)
    VALUES ('Lisa', 'Reyes', 'lisa.r@gym.com', '555-1102', 'Yoga & Flexibility', 40.00);

IF NOT EXISTS (SELECT 1 FROM TRAINER WHERE email = 'dan.w@gym.com')
    INSERT INTO TRAINER (first_name, last_name, email, phone, specialization, hourly_rate)
    VALUES ('Dan', 'Walsh', 'dan.w@gym.com', '555-1103', 'Cardio & Weight Loss', 42.00);

SET @trainer1 = (SELECT trainer_id FROM TRAINER WHERE email = 'mike.t@gym.com');
SET @trainer2 = (SELECT trainer_id FROM TRAINER WHERE email = 'lisa.r@gym.com');
SET @trainer3 = (SELECT trainer_id FROM TRAINER WHERE email = 'dan.w@gym.com');

-- ============================================================
-- 4. EQUIPMENT
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Treadmill A1')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Treadmill A1', 'Cardio', '2022-06-01', '2025-12-01', 'working');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Treadmill A2')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Treadmill A2', 'Cardio', '2022-06-01', '2025-12-01', 'working');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Rowing Machine B1')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Rowing Machine B1', 'Cardio', '2023-02-15', '2026-01-10', 'working');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Bench Press C1')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Bench Press C1', 'Strength', '2021-09-01', '2025-11-20', 'working');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Squat Rack C2')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Squat Rack C2', 'Strength', '2021-09-01', '2025-11-20', 'maintenance');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Spin Bike D1')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Spin Bike D1', 'Cardio', '2023-07-10', '2026-02-05', 'working');

IF NOT EXISTS (SELECT 1 FROM EQUIPMENT WHERE name = 'Cable Machine E1')
    INSERT INTO EQUIPMENT (name, type, purchase_date, last_maintenance, status)
    VALUES ('Cable Machine E1', 'Strength', '2022-03-20', '2025-10-15', 'broken');

-- ============================================================
-- 5. MEMBERS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM MEMBER WHERE email = 'john.doe@test.com')
    INSERT INTO MEMBER (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status)
    VALUES ('John', 'Doe', 'john.doe@test.com', '555-2001', '1990-03-15', '2025-11-01', 'Jane Doe', '555-2002', 'active');

IF NOT EXISTS (SELECT 1 FROM MEMBER WHERE email = 'sarah.smith@test.com')
    INSERT INTO MEMBER (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status)
    VALUES ('Sarah', 'Smith', 'sarah.smith@test.com', '555-3001', '1995-07-22', '2025-11-15', 'Bob Smith', '555-3002', 'active');

IF NOT EXISTS (SELECT 1 FROM MEMBER WHERE email = 'mike.jones@test.com')
    INSERT INTO MEMBER (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status)
    VALUES ('Mike', 'Jones', 'mike.jones@test.com', '555-4001', '1988-12-05', '2025-12-01', 'Lisa Jones', '555-4002', 'active');

IF NOT EXISTS (SELECT 1 FROM MEMBER WHERE email = 'emily.brown@test.com')
    INSERT INTO MEMBER (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status)
    VALUES ('Emily', 'Brown', 'emily.brown@test.com', '555-5001', '2000-05-10', '2026-01-10', 'Tom Brown', '555-5002', 'active');

IF NOT EXISTS (SELECT 1 FROM MEMBER WHERE email = 'chris.lee@test.com')
    INSERT INTO MEMBER (first_name, last_name, email, phone, date_of_birth, join_date, emergency_contact_name, emergency_contact_phone, status)
    VALUES ('Chris', 'Lee', 'chris.lee@test.com', '555-6001', '1985-09-18', '2026-02-01', 'Amy Lee', '555-6002', 'inactive');

SET @m1 = (SELECT member_id FROM MEMBER WHERE email = 'john.doe@test.com');
SET @m2 = (SELECT member_id FROM MEMBER WHERE email = 'sarah.smith@test.com');
SET @m3 = (SELECT member_id FROM MEMBER WHERE email = 'mike.jones@test.com');
SET @m4 = (SELECT member_id FROM MEMBER WHERE email = 'emily.brown@test.com');
SET @m5 = (SELECT member_id FROM MEMBER WHERE email = 'chris.lee@test.com');

-- ============================================================
-- 6. LOCKERS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'A01')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('A01', @m1, 'assigned');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'A02')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('A02', @m2, 'assigned');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'A03')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('A03', @m3, 'assigned');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'A04')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('A04', NULL, 'available');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'A05')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('A05', NULL, 'available');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'B01')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('B01', @m4, 'assigned');

IF NOT EXISTS (SELECT 1 FROM LOCKER WHERE locker_number = 'B02')
    INSERT INTO LOCKER (locker_number, member_id, status) VALUES ('B02', NULL, 'available');

-- ============================================================
-- 7. SUBSCRIPTIONS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM SUBSCRIPTION WHERE member_id = @m1)
BEGIN
    INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
    VALUES (@m1, @premiumId, '2025-11-01', '2026-11-01', 'active');
END
SET @s1 = (SELECT TOP 1 subscription_id FROM SUBSCRIPTION WHERE member_id = @m1);

IF NOT EXISTS (SELECT 1 FROM SUBSCRIPTION WHERE member_id = @m2)
BEGIN
    INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
    VALUES (@m2, @standardId, '2025-11-15', '2026-11-15', 'active');
END
SET @s2 = (SELECT TOP 1 subscription_id FROM SUBSCRIPTION WHERE member_id = @m2);

IF NOT EXISTS (SELECT 1 FROM SUBSCRIPTION WHERE member_id = @m3)
BEGIN
    INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
    VALUES (@m3, @basicId, '2025-12-01', '2026-12-01', 'active');
END
SET @s3 = (SELECT TOP 1 subscription_id FROM SUBSCRIPTION WHERE member_id = @m3);

IF NOT EXISTS (SELECT 1 FROM SUBSCRIPTION WHERE member_id = @m4)
BEGIN
    INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
    VALUES (@m4, @standardId, '2026-01-10', '2027-01-10', 'active');
END
SET @s4 = (SELECT TOP 1 subscription_id FROM SUBSCRIPTION WHERE member_id = @m4);

IF NOT EXISTS (SELECT 1 FROM SUBSCRIPTION WHERE member_id = @m5)
BEGIN
    INSERT INTO SUBSCRIPTION (member_id, plan_id, start_date, end_date, status)
    VALUES (@m5, @basicId, '2026-02-01', '2026-08-01', 'expired');
END
SET @s5 = (SELECT TOP 1 subscription_id FROM SUBSCRIPTION WHERE member_id = @m5);

-- ============================================================
-- 8. PAYMENTS (6 months of data Nov 2025 - May 2026)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM PAYMENT WHERE subscription_id = @s1 AND payment_date = '2025-11-01')
INSERT INTO PAYMENT (subscription_id, processed_by, amount, payment_date, method, status) VALUES
(@s1, @staff1, 79.99, '2025-11-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2025-11-15', 'cash',        'completed'),
(@s1, @staff1, 79.99, '2025-12-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2025-12-15', 'cash',        'completed'),
(@s3, @staff1, 29.99, '2025-12-01', 'debit_card',  'completed'),
(@s1, @staff1, 79.99, '2026-01-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2026-01-15', 'cash',        'completed'),
(@s3, @staff1, 29.99, '2026-01-01', 'debit_card',  'completed'),
(@s4, @staff2, 49.99, '2026-01-10', 'online',      'completed'),
(@s1, @staff1, 79.99, '2026-02-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2026-02-15', 'cash',        'completed'),
(@s3, @staff1, 29.99, '2026-02-01', 'debit_card',  'completed'),
(@s4, @staff2, 49.99, '2026-02-10', 'online',      'completed'),
(@s5, @staff1, 29.99, '2026-02-01', 'cash',        'completed'),
(@s1, @staff1, 79.99, '2026-03-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2026-03-15', 'cash',        'completed'),
(@s3, @staff1, 29.99, '2026-03-01', 'debit_card',  'completed'),
(@s4, @staff2, 49.99, '2026-03-10', 'online',      'completed'),
(@s1, @staff1, 79.99, '2026-04-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2026-04-15', 'cash',        'completed'),
(@s3, @staff1, 29.99, '2026-04-01', 'debit_card',  'completed'),
(@s4, @staff2, 49.99, '2026-04-10', 'online',      'completed'),
(@s1, @staff1, 79.99, '2026-05-01', 'credit_card', 'completed'),
(@s2, @staff2, 49.99, '2026-05-01', 'cash',        'completed');

-- ============================================================
-- 9. ATTENDANCE (check-ins over the past few weeks)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM ATTENDANCE WHERE member_id = @m1 AND check_in = '2026-04-28 08:00')
INSERT INTO ATTENDANCE (member_id, check_in, check_out) VALUES
(@m1, '2026-04-28 08:00', '2026-04-28 09:30'),
(@m2, '2026-04-28 09:00', '2026-04-28 10:15'),
(@m3, '2026-04-28 10:00', '2026-04-28 11:00'),
(@m1, '2026-04-29 08:00', '2026-04-29 09:00'),
(@m4, '2026-04-29 14:00', '2026-04-29 15:30'),
(@m2, '2026-04-30 09:00', '2026-04-30 10:30'),
(@m1, '2026-05-01 08:00', '2026-05-01 09:15'),
(@m3, '2026-05-01 11:00', '2026-05-01 12:00'),
(@m4, '2026-05-01 14:00', NULL),
(@m2, '2026-05-02 09:00', NULL);

-- ============================================================
-- 10. PT SESSIONS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM PT_SESSION WHERE member_id = @m1 AND trainer_id = @trainer1 AND scheduled_at = '2026-04-25 10:00')
INSERT INTO PT_SESSION (member_id, trainer_id, scheduled_at, duration_minutes, notes, status) VALUES
(@m1, @trainer1, '2026-04-25 10:00', 60, 'Focus on upper body strength',    'completed'),
(@m2, @trainer2, '2026-04-26 11:00', 45, 'Yoga and flexibility session',    'completed'),
(@m3, @trainer3, '2026-04-27 09:00', 60, 'Cardio interval training',        'completed'),
(@m1, @trainer1, '2026-05-02 10:00', 60, 'Lower body and core',             'scheduled'),
(@m4, @trainer2, '2026-05-03 11:00', 45, 'Beginner yoga intro',             'scheduled'),
(@m2, @trainer3, '2026-05-05 09:00', 60, 'Weight loss cardio plan',         'scheduled');

-- ============================================================
-- 11. MEMBER PROGRESS
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM MEMBER_PROGRESS WHERE member_id = @m1 AND recorded_date = '2026-02-01')
INSERT INTO MEMBER_PROGRESS (member_id, recorded_date, weight_kg, attendance_count, notes) VALUES
(@m1, '2026-02-01', 85.5, 8,  'Good progress on strength'),
(@m1, '2026-03-01', 84.0, 10, 'Losing weight steadily'),
(@m1, '2026-04-01', 82.5, 12, 'On track with goals'),
(@m2, '2026-02-01', 65.0, 6,  'Starting yoga sessions'),
(@m2, '2026-03-01', 64.5, 9,  'Improved flexibility'),
(@m2, '2026-04-01', 64.0, 11, 'Consistent attendance'),
(@m3, '2026-01-01', 95.0, 5,  'New member, building habit'),
(@m3, '2026-02-01', 93.5, 7,  'Improving cardio endurance'),
(@m3, '2026-03-01', 91.0, 9,  'Great improvement'),
(@m4, '2026-02-01', 58.0, 4,  'Focusing on toning'),
(@m4, '2026-03-01', 57.5, 8,  'Consistent with classes');

PRINT 'All seed data inserted successfully!';
PRINT 'Login credentials: admin / admin123  |  jsmith / pass123';
