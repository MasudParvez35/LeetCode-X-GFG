# Write your MySQL query statement below
select w2.id
from Weather w1 join Weather w2
on date_add(w1.recordDate, interval 1 day) = w2.recordDate
where w2.temperature > w1.temperature;