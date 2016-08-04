select distinct salesperson.name
from customer inner join orders on customer.Id = orders.customerid
			  inner join salesperson on orders.SalespersonID = salesperson.Id
where customer.name <> 'George'