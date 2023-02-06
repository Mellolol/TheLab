A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
create database ostermelo
character set utf8
collate utf8_hungarian_ci;
3. feladat:
select distinct
partnerek.telepules
from partnerek
group by partnerek.telepules
4. feladat:
select
count(kiszallitasok.sorsz) as alkalmak
from kiszallitasok
inner join partnerek
on kiszallitasok.partnerid = kiszallitasok.partnerid
where partnerek.telepules = 'Vác'
5. feladat:
select 
kiszallitasok.karton as legtobb
from kiszallitasok
where kiszallitasok.datum between 20160501 and 20160531
order by kiszallitasok.karton desc limit 1
6. feladat:
select
partnerek.telepules,
count(partnerek.id) as ID
from partnerek
group by partnerek.telepules
having count(partnerek.id) > 1
7. feladat:
select
gyumolcslevek.gynev as ital,
sum(kiszallitasok.karton*6) as doboz
from kiszallitasok
inner join gyumolcslevek
on kiszallitasok.gyumleid = gyumolcslevek.id
group by gyumolcslevek.gynev
order by doboz desc
limit 3
