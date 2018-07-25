select * from Aluno
select * from Turma
select * from Funcionario
select * from Professor
select * from Materia
select * from Boletim

insert into Turma
values('Hor1', 0 , 2)

insert into Funcionario
values(123456, 5555, '22/04/1995', 'Astolfo@gmail.com', 'Rua rua', 5500, 'Astolfo', 'Cozinhheiro', '123456', 1234568)

insert into Materia
values('Matematica')

insert into Professor
values(654321, 554455, '26/01/1995', 'Jef@gmail.com', 'Rua Avenida', 7500, 1, 'a',  'Jeff', '56461', 123, 1234568)

insert into aluno 
values(1,'roger@gmail.com',16, 'Rogerin', 'Adolfo', 123456789)

update Aluno set CodTurma = 1 where NumMat = 2

insert into Boletim
values(1,90,1,8,1)

go

create trigger TrigAlunoTurma
on Aluno for Update
as
begin
	Declare
	@cTurma as int,
	@qtdTurma as int;
	set nocount on;
	
	select @cTurma = CodTurma from inserted;
	select @qtdTurma = Count(CodTurma) from Aluno where CodTurma = @cTurma;
	update Turma set NumAlunos = @qtdTurma where CodTurma = @cTurma;
end

drop trigger TrigAlunoTurma