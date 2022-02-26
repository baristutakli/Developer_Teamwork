/* LEFT, RİGHT and FULL JOIN */
/* Patıka SQL Module Task 10 
-------------Questions----------
city tablosu ile country tablosunda bulunan şehir (city) ve ülke (country) isimlerini birlikte görebileceğimiz LEFT JOIN sorgusunu yazınız.
customer tablosu ile payment tablosunda bulunan payment_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz RIGHT JOIN sorgusunu yazınız.
customer tablosu ile rental tablosunda bulunan rental_id ile customer tablosundaki first_name ve last_name isimlerini birlikte görebileceğimiz FULL JOIN sorgusunu yazınız.
-------1-----
select city.city, country.country from city left join country on city.country_id=country.country_id;
-------2------
select payment.payment_id,customer.first_name,customer.last_name from customer right join payment on customer.customer_id=payment.customer_id;
-------3---------
select rental.rental_id,customer.first_name,customer.last_name from customer full join rental on customer.customer_id=rental.customer_id;
*/
