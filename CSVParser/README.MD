# Goal
A .csv file contains invoice data. 

Each line is part of the invoice data, but first line contains the name list of the invoce fields.
A sample file could be:

```
Num_Factura, Fecha, Bruto, Neto, IVA, IGIC, Concepto, CIF_cliente, NIF_cliente
1,02/05/2019,1008,810,19,,ACERLaptop,B76430134,
2,03/08/2019,2000,2000,,8,MacBook Pro,,78544372A
3,03/12/2019,1000,2000,19,8, LenovoLaptop,,78544372A
``` 

Business rules are:

- Some fields can be empty, two commas can appear side by side or at the end
- Num_Factura cannot be repeated, in that case, all lines with that number should be removed
- Taxes IVA e IGIC are exclusive, that is, only one of them can be applied. Those lines containing both should not be taken into account.
- CIF_cliente and NIF_cliente are exclusive, only one of them can be used.
- Neto is the result of applying taxes to Bruto field, If Neto is not correct that invoice line should not be taken into account.
