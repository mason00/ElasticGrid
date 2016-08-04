select max(salesperson.name)
from orders inner join salesperson on salesperson.Id = orders.SalespersonID
group by salesperson.id
having count(orders.Id) > 2