select name
from (select salesperson.name, rank() over (order by salesperson.salary desc) as r
from salesperson) as temp
where temp.r = 3