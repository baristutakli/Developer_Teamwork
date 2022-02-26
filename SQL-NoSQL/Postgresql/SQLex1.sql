/* Postgresql tutorial*/
/*select * from actor where actor_id=3;*/

/*
select first_name, last_name from actor where actor_id>10 and actor_id<20;
*/
/*
select first_name, last_name from actor where actor_id=5 or actor_id<20;*/
/*
SELECT *
FROM actor 
WHERE first_name = 'Penelope' OR first_name = 'Bob' ;*/

/*film tablosunda bulunan title ve description sütunlarındaki verileri sıralayınız.*/
/*select title,description from film*/
/*select * from film where length>60 and length<75;*/

/*film tablosunda bulunan tüm sütunlardaki verileri rental_rate 0.99 VE replacement_cost 12.99 VEYA 28.99 olma koşullarıyla sıralayınız
select *from film where rental_rate =0.99 and (replacement_cost = 12.99 or replacement_cost=28.99);*/
/* customer tablosunda bulunan first_name sütunundaki değeri 'Mary' olan müşterinin last_name sütunundaki değeri nedir
select last_name from customer where first_name ='Mary';*/

/*film tablosundaki uzunluğu(length) 50 ten büyük OLMAYIP aynı zamanda rental_rate değeri 2.99 veya 4.99 OLMAYAN verileri sıralayınız.*/

select *from film where length<50 and (rental_rate != 2.99 or rental_rate!=4.99);


