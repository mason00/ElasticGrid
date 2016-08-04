select sum(Orders.CostOfUnit * Orders.NumberOfUnits) as TotalAmount, MONTH(orders.orderdata), Year(orders.orderdata)
from Orders
group by MONTH(orders.orderdata), Year(orders.orderdata)
order by Year(orders.orderdata) desc , MONTH(orders.orderdata) desc