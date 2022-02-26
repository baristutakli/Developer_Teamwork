/* SQl aggreagte  functions 
 PAtıka SQL Module Task 6
----------- Questions-----------
film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?
film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?
film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?
film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?
----1----
select avg(rental_rate) from film;
----2----
select count(*) from film where title like '%c'
----3----
select Max(length) from film where rental_rate =0.99;
----4----
select Count(distinct replacement_cost) from film where length>150
*/


