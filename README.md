# ADO
Proyecto Base Ado
### Ejecutar el siguinte script en sus base de datos Scripts
    create table Estudiantes(
    Nombre varchar(50) not null,
    Apellido Varchar(50) not null,
    ID int identity(1,1) not null primary key)
    go
    create proc InsertEstudiante
     @Nombre  varchar(50),
     @apellido  varchar(50)

     as
     begin
     insert Estudiantes(Nombre,Apellido) values (@Nombre, @apellido)
     end
