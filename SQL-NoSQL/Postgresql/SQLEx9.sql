/* INNER JOIN */
/* Patıka SQL Module Task 9 
-------------Questions----------
city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz INNER JOIN sorgusunu yazınız.
-------1-------
select city.city, country.country from city inner join country on country.country_id= city.country_id
-------2-------
select payment.payment_id,customer.first_name,customer.last_name from customer inner join payment 
on
customer.customer_id=payment.customer_id;
-------3-------
select rental.rental_id, customer.first_name,customer.last_name from customer 
inner join rental on  rental.customer_id =customer.customer_id
*/



