A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
create database Varosok
character set utf8
collate utf8_hungarian_ci;
3. feladat:
select
vnev
from varos
where vnev like '%vásár%'
4. feladat:
select
vnev,
nepesseg,
terulet
from varos
where varos.terulet > 400
order by nepesseg desc
5. feladat:
select
vnev,
nepesseg
from varos
inner join megye
on varos.megyeid = megye.id
where megye.mnev = 'Fejér'
and varos.nepesseg > 15000
6. feladat:
select
sum(varos.nepesseg) as nepesseg,
varostipus.vtip as varos_tipusa,
count(varos.id) as varosok_szama
from varos
inner join varostipus
on varos.vtipid = varostipus.id
where varostipus.vtip <> 'Főváros'
group by varostipus.vtip
7. feladat:
select
megye.mnev as megye,
count(varos.id) as db
from varos
inner join megye 
on varos.megyeid = megye.id
where varos.kisterseg not like varos.jaras
having count(varos.id) > 8  
group by megye.mnev





