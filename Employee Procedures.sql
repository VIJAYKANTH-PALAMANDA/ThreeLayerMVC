--Procedure to Add Employee
CREATE PROCEDURE AddEmployee
	@Name varchar(max),
	@Salary bigint,
	@DepartmentId int
AS
BEGIN
	Insert into Employees values (@Name,@Salary,@DepartmentId)
END
--Procedure to Update Employee based on Id
CREATE PROCEDURE UpdateEmployee
	@Id int,
	@Name varchar(max),
	@Salary bigint,
	@DepartmentId int
AS
BEGIN
	Update Employees set
	Name = @Name,
	Salary = @Salary,
	DepartmentId = @DepartmentId
	where Id = @Id
END
-- Procedure to Update Salary of Employee based on Id
CREATE PROCEDURE UpdateSalary
	@Id int,
	@Salary bigint
AS
BEGIN
	Update Employees set
	Salary = @Salary
	where Id = @Id
END
-- Procedure to Delete Employee based on Id
CREATE PROCEDURE DeleteEmployee
	@Id int
AS
BEGIN
	Delete from Employees
	where Id = @Id
END
--Procedure to Assign Department to the Employee
CREATE PROCEDURE AssignDepartment
	@Id int,
	@DepartmentId int
AS
BEGIN
	Update Employees set DepartmentId = @DepartmentId
	where Id = @Id
END
--Procedure to getEmployees by Department
CREATE PROCEDURE getEmployee
	@DepartmentId int
AS
BEGIN
	select * from Employees
	where DepartmentId = @DepartmentId
END
--Procedure to getAllEmployees
CREATE PROCEDURE getAllEmployee
AS
BEGIN
	select * from Employees
END