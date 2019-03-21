USE	Fakultet
select
stud.mbrStud
,concat(stud.imeStud+' '+stud.prezStud) AS 'Ime i prezime'
from stud

--3.3
SELECT DISTINCT stud.imeStud
FROM stud
ORDER BY stud.imeStud DESC

--3.4
SELECT stud.mbrStud 
FROM stud INNER JOIN ispit
ON stud.mbrSTUD=ispit.mbrStud
WHERE ispit.sifPred=146
AND ispit.ocjena>1

--3.22
SELECT *
--n.*,
--m1.nazMjesto,
--m2.nazMjesto,
--.nazZupanija
from nastavnik n left join ispit i 
on n.sifNastavnik=i.sifNastavnik
inner join stud s
on i.mbrStud=s.mbrStud
left join mjesto m1
on m1.pbr=n.pbrStan
left join zupanija z1
on z1.sifZupanija=m1.sifZupanija
left join mjesto m2
on m2.pbr=s.pbrStan
left join zupanija z2
on z2.sifZupanija=m2.sifZupanija
WHERE m1.sifZupanija=m2.sifZupanija
AND m1.pbr<>m2.pbr