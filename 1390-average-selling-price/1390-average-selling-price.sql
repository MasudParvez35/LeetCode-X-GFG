/* Write your T-SQL query statement below */
SELECT p.product_id, COALESCE(ROUND(sum(price*units)*1.0/SUM(units),2),0) as average_price
FROM Prices p LEFT JOIN UnitsSold u
ON p.product_id = u.product_id AND purchase_date BETWEEN start_date AND end_date
group by p.product_id;