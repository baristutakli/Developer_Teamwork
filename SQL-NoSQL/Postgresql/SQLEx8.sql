/* Create Drop Table
Patıka SQL Module Task 8
Used https://www.mockaroo.com/ to generate data
---- Questions-----
test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
-----1----
create table employee (
id  serial PRIMARY KEY,
name VARCHAR(50),
birthday DATE,
email VARCHAR(100)
);
--------2------
insert into employee (name, birthday, email) values ('Heindrick', '1923-09-02', 'helmer0@weibo.com');
insert into employee (name, birthday, email) values ('Pincus', '1974-07-09', 'pbeathem1@etsy.com');
insert into employee (name, birthday, email) values ('Mandel', '1957-02-18', 'mrosebotham2@ehow.com');
insert into employee (name, birthday, email) values ('Jeanne', '1939-11-09', 'jmalley3@histats.com');
insert into employee (name, birthday, email) values ('Gerry', '1958-09-28', 'gkeates4@pcworld.com');
insert into employee (name, birthday, email) values ('Bertie', '1958-05-05', 'bolley5@virginia.edu');
insert into employee (name, birthday, email) values ('Arin', '1911-09-23', 'agittoes6@lycos.com');
insert into employee (name, birthday, email) values ('Haley', '1945-11-28', 'hgiovanardi7@jigsy.com');
insert into employee (name, birthday, email) values ('Walker', '1906-11-21', 'wmartini8@about.me');
insert into employee (name, birthday, email) values ('Katine', '1901-10-01', 'kmuffen9@nytimes.com');
insert into employee (name, birthday, email) values ('Jaquelin', '1955-04-11', 'jbuscha@adobe.com');
insert into employee (name, birthday, email) values ('Tiertza', '1916-02-22', 'tkalinskyb@squidoo.com');
insert into employee (name, birthday, email) values ('Darnall', '1953-01-18', 'dpearmainc@cnbc.com');
insert into employee (name, birthday, email) values ('Evey', '1941-09-17', 'eosgard@skyrock.com');
insert into employee (name, birthday, email) values ('Felicity', '1910-07-04', 'fdagostinie@reuters.com');
insert into employee (name, birthday, email) values ('Fidela', '1998-03-16', 'fjulianf@nasa.gov');
insert into employee (name, birthday, email) values ('Aristotle', '1975-05-31', 'ajantzeng@unesco.org');
insert into employee (name, birthday, email) values ('Johanna', '1940-05-17', 'jcristofaninih@lycos.com');
insert into employee (name, birthday, email) values ('Chuck', '1960-07-13', 'cgeisti@surveymonkey.com');
insert into employee (name, birthday, email) values ('Cull', '1987-03-24', 'cmaffij@goo.ne.jp');
insert into employee (name, birthday, email) values ('Maryrose', '1930-12-12', 'masmank@dailymotion.com');
insert into employee (name, birthday, email) values ('Pierette', '1972-10-15', 'pkauschel@opera.com');
insert into employee (name, birthday, email) values ('Ellene', '1977-04-25', 'eovenm@stanford.edu');
insert into employee (name, birthday, email) values ('Esme', '1923-11-25', 'ehartmann@sbwire.com');
insert into employee (name, birthday, email) values ('Parsifal', '1934-11-21', 'ptumpaneo@google.nl');
insert into employee (name, birthday, email) values ('Katinka', '1972-04-01', 'kpinksp@whitehouse.gov');
insert into employee (name, birthday, email) values ('Bea', '1935-10-28', 'bmetzingq@drupal.org');
insert into employee (name, birthday, email) values ('Dario', '1906-05-04', 'dbennettr@dell.com');
insert into employee (name, birthday, email) values ('Dorthea', '1917-07-21', 'dclaasens@ning.com');
insert into employee (name, birthday, email) values ('Finlay', '1922-04-19', 'fstephenst@uiuc.edu');
insert into employee (name, birthday, email) values ('Merlina', '1905-08-06', 'mdivillu@reuters.com');
insert into employee (name, birthday, email) values ('Tulley', '1972-07-11', 'tdreverv@eventbrite.com');
insert into employee (name, birthday, email) values ('Aland', '1989-08-26', 'alefriecw@ycombinator.com');
insert into employee (name, birthday, email) values ('Essie', '1967-04-04', 'eivanchenkovx@ezinearticles.com');
insert into employee (name, birthday, email) values ('Fabian', '1946-04-10', 'fbreensy@shinystat.com');
insert into employee (name, birthday, email) values ('Tybalt', '1917-04-13', 'toleszcukz@tuttocitta.it');
insert into employee (name, birthday, email) values ('Odelia', '1937-08-29', 'ospurling10@facebook.com');
insert into employee (name, birthday, email) values ('Lorene', '1908-05-28', 'lmulvey11@fotki.com');
insert into employee (name, birthday, email) values ('Conney', '1927-03-28', 'cpattini12@dion.ne.jp');
insert into employee (name, birthday, email) values ('Jaynell', '1904-12-09', 'jhutfield13@state.gov');
insert into employee (name, birthday, email) values ('Hebert', '1975-10-10', 'hturmell14@wp.com');
insert into employee (name, birthday, email) values ('Moyna', '1912-02-13', 'mslate15@ning.com');
insert into employee (name, birthday, email) values ('Lane', '1918-05-24', 'ltaile16@abc.net.au');
insert into employee (name, birthday, email) values ('Bill', '1947-10-26', 'batteridge17@vimeo.com');
insert into employee (name, birthday, email) values ('Dario', '1906-02-16', 'dbraithwait18@japanpost.jp');
insert into employee (name, birthday, email) values ('Roxie', '1966-06-06', 'rdoylend19@vkontakte.ru');
insert into employee (name, birthday, email) values ('Lyon', '1953-06-28', 'lperis1a@blogs.com');
insert into employee (name, birthday, email) values ('Alva', '1950-01-15', 'aaireton1b@newsvine.com');
insert into employee (name, birthday, email) values ('Aluino', '1997-06-07', 'aportigall1c@guardian.co.uk');
insert into employee (name, birthday, email) values ('Karl', '1941-12-12', 'kpenke1d@yandex.ru');
------3--------
update employee set name ='Roxieee' where id=46;
update employee set name ='Lyonnn' where id=47;
update employee set name= 'Alvaaa' where id=48;
update employee set name='Aluinooo' where id=49;
update employee set name= 'Karlll' where id=50;

----4-----
delete from employee  where id=46;
delete from employee  where id=47;
delete from employee   where id=48;
delete from employee   where id=49;
delete from employee   where id=50;
*/


