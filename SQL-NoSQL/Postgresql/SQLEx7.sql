/* SQL Group by and Having
Patıka SQL Module Task 7

---------questions -----------
film tablosunda bulunan filmleri rating değerlerine göre gruplayınız.
film tablosunda bulunan filmleri replacement_cost sütununa göre grupladığımızda film sayısı 50 den fazla olan replacement_cost değerini ve karşılık gelen film sayısını sıralayınız.
3. customer tablosunda bulunan store_id değerlerine karşılık gelen müşteri sayılarını nelerdir?
4. city tablosunda bulunan şehir verilerini country_id sütununa göre gruplandırdıktan sonra en fazla şehir sayısı barındıran country_id bilgisini ve şehir sayısını paylaşınız.
----1----
select rating from film group by rating;
----2----
select count(*) from film where length>50 group by replacement_cost ;
----3---- 
select count(*) from customer group by store_id

-----4----
select country_id from city group by country_id order by country_id desc limit 1;
*/ 
/*
select Count(*),country_id as numberOfCity from city group by country_id order by numberOfCity desc limit 1;
*/

