/*LIMIT ve OFFSET */
/*-- we selected only 10 items -- 
select * from film where title like 'B%'
Order by length desc limit 10;
*/

/*--- offset---
We pass a value that we do not want to count
for instance, here we offset 6
SELECT * FROM film
WHERE title LIKE 'B%'
ORDER BY length DESC
OFFSET 6
LIMIT 4;
*/


/* ---------- Patika SQl Module Task 5
film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en uzun (length) 5 filmi sıralayınız.
film tablosunda bulunan ve film ismi (title) 'n' karakteri ile biten en kısa (length) ikinci(6,7,8,9,10) 5 filmi(6,7,8,9,10) sıralayınız.
customer tablosunda bulunan last_name sütununa göre azalan yapılan sıralamada store_id 1 olmak koşuluyla ilk 4 veriyi sıralayınız.
----1-------
select * from film where title like '%n' order by length desc limit 5;

--- 2------
select * from film where title like '%n' 
order by length asc
offset  5
limit 5;

---- 3-----
select * from customer where store_id = 1
order by last_name desc
limit 4;
*/




