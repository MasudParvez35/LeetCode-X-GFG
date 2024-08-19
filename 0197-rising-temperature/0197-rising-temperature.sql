/* Write your T-SQL query statement below */
select w2.id
from Weather w1 join Weather w2
on DATEADD(day, 1, w1.recordDate) = w2.recordDate
where w2.temperature > w1.temperature;