/*Calculates the total price of an order*/
SET SERVEROUTPUT ON
CREATE or replace Function CalcOrder 
(ORDERQAL in number, ORDERPRICE in number, ORDERTAX in number, ORDERLIMIT in number, ORDERSALE in number) 
   RETURN number
IS 
BEGIN
  IF(ORDERQAL <= 0) THEN
    RETURN 0;
  ELSIF (ORDERQAL >= ORDERLIMIT) then
    RETURN ((ORDERLIMIT * ORDERQAL) + ORDERTAX) - ORDERSALE;
  else
    RETURN ((ORDERPRICE * ORDERQAL) + ORDERTAX) - ORDERSALE;
  END IF;

end CalcOrder;

SELECT quantity, price, CalcOrder(quantity, price, 4, 99, 0) AS TotalPrice
FROM ORDERITEMS;

/*Determines if the order will be ready*/
SET SERVEROUTPUT ON
CREATE or replace Function CalcOrderReady 
(ORDERQAL in number, ORDERBAKING_TIM in number, ORDERPACKAGING_TIM in number, TIMENeeded in number) 
   RETURN string
IS
BEGIN
  IF((ORDERQAL * (ORDERBAKING_TIM + ORDERPACKAGING_TIM)) >= TIMENeeded) THEN
    RETURN 'Late';
  else
    RETURN 'On Time';
  END IF;
end CalcOrderReady;

SELECT quantity, CalcOrderReady(quantity, 15, 10, 50) AS OrderReady
FROM ORDERITEMS;