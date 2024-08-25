/* Write your T-SQL query statement below */
select emp.name as Employee
From Employee emp join Employee mng
on emp.managerId = mng.id 
where emp.salary > mng.salary;