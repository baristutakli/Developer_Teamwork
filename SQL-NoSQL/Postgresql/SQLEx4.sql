/*Odev4*/
/*
film tablosunda bulunan replacement_cost sütununda bulunan birbirinden farklı değerleri sıralayınız.
film tablosunda bulunan replacement_cost sütununda birbirinden farklı kaç tane veri vardır?
film tablosunda bulunan film isimlerinde (title) kaç tanesini T karakteri ile başlar ve aynı zamanda rating 'G' ye eşittir?
country tablosunda bulunan ülke isimlerinden (country) kaç tanesi 5 karakterden oluşmaktadır?
city tablosundaki şehir isimlerinin kaç tanesi 'R' veya r karakteri ile biter?
*/
/*
------------1----------
select distinct replacement_cost from film;
------------2----------
select Count(distinct replacement_cost) from film;

-------------3--------------
select count(title) from film where title like 'T%' and rating='G';

-------------4---------------
select Count(country) from country where country like'_____';
-------------5---------------
select count(country) from country where country ilike '%t';
*/

