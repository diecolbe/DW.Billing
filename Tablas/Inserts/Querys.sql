select * from Tbl_Cliente;
select * from Tbl_Factura;
select * from Tbl_TipoDocumento;
select * from Tbl_Detalle_Factura;
select * from Tbl_Producto;


--Lista de productos 
select id_producto, descripcion, Precio,Stock,Fecha_Ingreso
from Tbl_Producto;

--Obtener la lista de precios de todos los productos
select descripcion, Precio 
from Tbl_Producto;

--Obtener la lista de productos cuya existencia en el inventario haya llegado al mínimo permitido (5 unidades)
select descripcion 
from Tbl_Producto
where stock<=5;

--Obtener una lista de clientes no mayores de 35 años que hayan realizado compras entre el 1 de febrero de 2000 y el 25 de mayo de 2000
select b.Nombres from 
(select ( cli.Nombres+' '+cli.Apellidos)Nombres,
        (year(CURRENT_TIMESTAMP) - year(cli.Fecha_Nacimiento)) edad,
		fact.Fecha_Facturacion
 from Tbl_Factura fact,
      Tbl_Cliente cli
where fact.Codigo_cliente=cli. Documento) As B
where b.edad<=35
And Fecha_Facturacion BETWEEN '2021-01-28' AND '2021-07-17';

--Obtener el valor total vendido por cada producto en el año 2000
Select pro.descripcion , sum(det.Total) total
From Tbl_Factura fact
    JOIN Tbl_Detalle_Factura det ON fact.Num_Factura=det.Cod_Factura
	JOIN Tbl_Producto pro ON  pro.Id_Producto=det.Codigo_producto
where Fecha_Facturacion BETWEEN '2021-01-01' AND '2021-07-16'
Group by  det.Total,pro.descripcion;

--Obtener la última fecha de compra de un cliente y según su frecuencia de compra estimar en qué fecha podría volver a comprar.

Select cli.Nombres+' '+cli.apellidos, 
       Max(fecha_facturacion) ,
       COUNT(fecha_facturacion) Frecuncy
From Tbl_Factura fact
JOIN Tbl_Cliente cli on fact.codigo_cliente =cli.documento
Group by cli.nombres,cli.apellidos;

