/* UNION,INTERSECT and  EXCEPT */
/* Patıka SQL Module Task 11 
-------------Questions----------
actor ve customer tablolarında bulunan first_name sütunları için tüm verileri sıralayalım.
actor ve customer tablolarında bulunan first_name sütunları için kesişen verileri sıralayalım.
actor ve customer tablolarında bulunan first_name sütunları için ilk tabloda bulunan ancak ikinci tabloda bulunmayan verileri sıralayalım.
İlk 3 sorguyu tekrar eden veriler için de yapalım.
---------1-----------
(select first_name from actor) union (select first_name from customer);
---------2------------
(select first_name from actor) intersect (select first_name from customer);
---------3-------------
(select first_name from actor) except (select first_name from customer);
---------4----------
(select first_name from actor) except all (select first_name from customer);
*/

