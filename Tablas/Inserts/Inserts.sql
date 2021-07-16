--Tipos de documentos
Insert into Tbl_TipoDocumento(Id_Tipo_documento,Descripcion)
values(1,'Cédula de ciudadanía');

Insert into Tbl_TipoDocumento(Id_Tipo_documento,Descripcion)
values(2,'Cédula de extranjería');

Insert into Tbl_TipoDocumento(Id_Tipo_documento,Descripcion)
values(3,'Tarjeta de extranjería');

Insert into Tbl_TipoDocumento(Id_Tipo_documento,Descripcion)
values(4,'Tarjeta de identidad');

Insert into Tbl_TipoDocumento(Id_Tipo_documento,Descripcion)
values(5,'Pasaporte ');

--Clientes
Insert into Tbl_Cliente (Documento,Cod_tipo_documento,Nombres,Apellidos,Direccion,Telefono,Email,Fecha_Nacimiento)
values('123456',1,'Pedro','perez gomez','Calle 1 casa # 1','310123456','pedro@prueba.com', '1984-03-01 00:00:00.000');

Insert into Tbl_Cliente (Documento,Cod_tipo_documento,Nombres,Apellidos,Direccion,Telefono,Email,Fecha_Nacimiento)
values('123460',1,'Juan','gonzalez rivera','Calle 2 casa # 2','310123460','Juan@prueba.com', '1990-05-20 00:00:00.000');

Insert into Tbl_Cliente (Documento,Cod_tipo_documento,Nombres,Apellidos,Direccion,Telefono,Email,Fecha_Nacimiento)
values('123489',1,'Angela','lopez martinez','Calle 3 casa # 3','310123489','Angela@prueba.com', '1989-06-23 00:00:00.000');

Insert into Tbl_Cliente (Documento,Cod_tipo_documento,Nombres,Apellidos,Direccion,Telefono,Email,Fecha_Nacimiento)
values('123423',1,'Diana','vargas londoño','Calle 4 casa # 4','310123423','Diana@prueba.com', '2000-09-23 00:00:00.000');

Insert into Tbl_Cliente (Documento,Cod_tipo_documento,Nombres,Apellidos,Direccion,Telefono,Email,Fecha_Nacimiento)
values('123471',5,'Daniela','ortegon londoño','Calle 5 casa # 5','310123471','Daniela@prueba.com', '1989-08-10 00:00:00.000');

--Productos
Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto A',100,10,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto B',200,10,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto C',300,10,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto D',400,10,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto E',100,20,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto F',250,8,'2021-07-15 00:00:00.000');

Insert into Tbl_Producto(Descripcion,Precio,Stock,Fecha_ingreso)
values ('Producto G',500,9,'2021-07-15 00:00:00.000');






