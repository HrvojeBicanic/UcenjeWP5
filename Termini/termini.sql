use tereni;
select * from korisnici where id=2;
update	korisnici set email='gojt.rena12@gmail.com' where  id=2;
update	korisnici set broj_mob='+38597458745' where  id=2;

select * from tereni;
update tereni set naziv_terena='Teren 3a' where id=4;
update tereni set tip_terena='Mali nogomet' where id=4;
update tereni set tip_terena='Tenis' where id=1;
update tereni set tip_terena='Košarka' where id=2;
update tereni set tip_terena='Rukomet' where id=3;
update tereni set tip_terena='Vaterpolo' where id=5;
update tereni set tip_terena='Skvoš' where id=6;

select * from termini;
delete 