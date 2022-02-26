/*Subqueries , Any and All  */
/* Patıka SQL Module Task 12 

SELECT * FROM book WHERE page_number >
(SELECT page_number FROM book WHERE title = 'Gülün Adı');
-------------Questions----------

film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?
film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?
film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.
payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.
----------1--------
select count(*) from film where length >(select AVG(length) from film);
----------2--------
select count(*) from film where rental_rate = (select max(rental_rate) from film);
----------3--------
select * from film where rental_rate = (select min(rental_rate) from film) and 
replacement_cost =(select min(replacement_cost ) from film);
----------4--------
select customer.first_name,customer.last_name from payment inner join customer on customer.customer_id =payment.customer_id where amount = (select max(amount) from payment) ;
*/





