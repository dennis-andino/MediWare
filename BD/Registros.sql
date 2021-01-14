----############### REGISTROS ########################
USE BDMediware
--LOGIN 
insert into dbo.LogUsuarios (log_Id,log_Clave,log_NombreCompleto,log_IDempleado)
values ('0801199318270','password','Dennis Andino','1')

insert into dbo.LogUsuarios (log_Id,log_Clave,log_NombreCompleto,log_IDempleado)
values ('0801199318271','password','Xavier Alejandro Lagos Andino','2')

insert into dbo.LogUsuarios (log_Id,log_Clave,log_NombreCompleto,log_IDempleado)
values ('0801199318272','password','Keren Elvir','3')

insert into dbo.LogUsuarios (log_Id,log_Clave,log_NombreCompleto,log_IDempleado)
values ('0801199318273','password','Melissa Sosa','4')

insert into dbo.LogUsuarios (log_Id,log_Clave,log_NombreCompleto,log_IDempleado)
values ('0801199318274','password','Dante Cartagena','5')

select * from dbo.LogUsuarios
--REGISTROS CIUDADES
insert into dbo.Ciudades(Ciu_nombre)values('Tegucigalpa')
insert into dbo.Ciudades(Ciu_nombre)values('San Pedro Sula')
insert into dbo.Ciudades(Ciu_nombre)values('Danli')
insert into dbo.Ciudades(Ciu_nombre)values('Catacamas')
insert into dbo.Ciudades(Ciu_nombre)values('Lempira')
insert into dbo.Ciudades(Ciu_nombre)values('Choloma')
insert into dbo.Ciudades(Ciu_nombre)values('La Ceiba')
insert into dbo.Ciudades(Ciu_nombre)values('Puerto Cortes')
--REGISTROS DEPARTAMENTOS
insert into dbo.Departamento(dep_nombre)values('Francisco Mrz')
insert into dbo.Departamento(dep_nombre)values('Comayagua')
insert into dbo.Departamento(dep_nombre)values('Cortes')
insert into dbo.Departamento(dep_nombre)values('El paraiso')
insert into dbo.Departamento(dep_nombre)values('Gracias a Dios')
insert into dbo.Departamento(dep_nombre)values('Colon')
insert into dbo.Departamento(dep_nombre)values('Choluteca')

--REGISTROS PAISES O NACIONALIDADES
insert into dbo.Nacionalidad(na_nombre)values('Honduras')
insert into dbo.Nacionalidad(na_nombre)values('El Salvador')
insert into dbo.Nacionalidad(na_nombre)values('Costa Rica')
insert into dbo.Nacionalidad(na_nombre)values('Panama')
insert into dbo.Nacionalidad(na_nombre)values('Nicaragua')
insert into dbo.Nacionalidad(na_nombre)values('Mexico')
insert into dbo.Nacionalidad(na_nombre)values('Guatemala')
insert into dbo.Nacionalidad(na_nombre)values('Colombia')

--REGISTROS DE	PADECIMIENTOS
insert into  dbo.Padecimientos(pad_nombre) values('Miopia')
insert into  dbo.Padecimientos(pad_nombre) values('Diabetes')
insert into  dbo.Padecimientos(pad_nombre) values('Colon Irritable')
insert into  dbo.Padecimientos(pad_nombre) values('Migraña')
insert into  dbo.Padecimientos(pad_nombre) values('Anemia')
insert into  dbo.Padecimientos(pad_nombre) values('Arit Cardiaca')
insert into  dbo.Padecimientos(pad_nombre) values('presion')
insert into  dbo.Padecimientos(pad_nombre) values('depresion')

--REGISTROS ESPECIALIDADES
insert into dbo.Especialidades(esp_nombre)values ('medicina General')
insert into dbo.Especialidades(esp_nombre)values ('PSicologo')
insert into dbo.Especialidades(esp_nombre)values ('Psiquiatra')
insert into dbo.Especialidades(esp_nombre)values ('Pediatra')
insert into dbo.Especialidades(esp_nombre)values ('Urologo')
insert into dbo.Especialidades(esp_nombre)values ('Ginecologo')
insert into dbo.Especialidades(esp_nombre)values ('Cirugia menor')
insert into dbo.Especialidades(esp_nombre)values ('Cardiologia')

--REGISTROS DE ASEGURADOS
insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0801199318270','Keylin Celena','Castillo Palma',1,1,1,'1996-2-2',165,130,'F','S',null,1,1,'Col hato de enmedio bloque 1 casa 24','Claro','www.claro.hn',1,'Recepcion','Medired',1)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0801199312345','Jose Alberto','Castillo Rodriguez',1,1,1,'1993-2-2',165,130,'M','C','Maria Joselina Paz Barahona',1,1,'Col el bosque bloque 1 casa 123','mipollo','www.mipollo.hn',1,'vendedor',null,null)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0611199318270','Keylin Mabel','Rodriguez Baca',1,1,1,'1977-2-2',178,200,'F','S',null,1,1,'Col Montes de Olivo bloque 1 casa 87','Frelancer','wolkana.pk',1,'diseñador','ficored',3)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0621197018270','Jose Ismael','Castillo Palma',1,1,1,'1996-3-25',180,250,'M','S',null,1,1,'Col hato de enmedio bloque 4 casa 24','Tigo','www.tigo.hn',1,'Vendedor',null,null)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0801199918270','Tatiana Marina','Gomez Gomez',1,1,1,'1999-3-2',165,130,'F','C','Jose mario Benitez Diaz',1,1,'Col Nueva Orleans bloque 1 casa 19','Claro','www.claro.hn',1,'Recepcion','Medired',0)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0801199018270','Mia Alejandra','Elvir Godoy',1,1,1,'1990-5-30',170,111,'F','S',null,1,1,'Res loma verde bloque 1 casa 2','Clover','www.clover.hn',1,'empaque','Medired',5)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0801199325682','Bryan Tomas','Aquiles Brinco',1,1,1,'1993-11-25',165,200,'M','S',null,1,1,'Col Santa Cecilia bloque 3t casa 1123','Los Pinares','www.pinar.hn',1,'Abogado','supimed',3)

insert into dbo.AseguradosTBL(
Aseg_Id,Aseg_Nombre,Aseg_Apellido,Aseg_Nacionalidad,Aseg_DeptoNac,Aseg_CiudadNac,Aseg_FechaNac,
Aseg_Estatura,Aseg_Peso,Aseg_Genero,Aseg_EstadoCivil,Aseg_nomConyugue,Aseg_DeptoRes,Aseg_CiudadRes,
Aseg_direccionRes,Aseg_NomEmpresa ,Aseg_EmpresaWeb,Aseg_AntiguedadLab,Aseg_puestoTrab,Aseg_nomAseguradoraT,Aseg_tiempoT)
values('0455A-2018-321','Jonh Travolta','Magno Clinton',1,1,1,'1960-2-2',165,130,'M','V','Maria Jose Elvir',1,1,'Res del norte bloque 1 casa 22','777','www.777.hn',1,'gerente','Hondured',23)

--REGISTROS DE MEDICOS
insert into dbo.MedicoTBL(med_Colegiacion,med_Nombres,med_Apellidos,med_LugTrabajo,med_Honorarios,med_pais,med_ciudad,med_Depto,med_Detalledir,med_redSeg)
values('568-2011-TG','Mauricio Alberto','Varela Ibranovich','Clinica 24',40000.27,1,1,1,'circunvalacion calle 3 local 24','S')
insert into dbo.MedicoTBL(med_Colegiacion,med_Nombres,med_Apellidos,med_LugTrabajo,med_Honorarios,med_pais,med_ciudad,med_Depto,med_Detalledir,med_redSeg)
values('1568-2012-SP','Berta Caceres','Espinoza Martinez','Clinica 29',50000.27,1,1,1,'circunvalacion calle 4 local 124','S')
insert into dbo.MedicoTBL(med_Colegiacion,med_Nombres,med_Apellidos,med_LugTrabajo,med_Honorarios,med_pais,med_ciudad,med_Depto,med_Detalledir,med_redSeg)
values('5681-2011-CM','Jorge Mauricio','Turcios Caceres','Clinica 45',30000.27,1,1,1,'circunvalacion calle 67 local 12','N')
insert into dbo.MedicoTBL(med_Colegiacion,med_Nombres,med_Apellidos,med_LugTrabajo,med_Honorarios,med_pais,med_ciudad,med_Depto,med_Detalledir,med_redSeg)
values('5618-2010-TG','Carlos Alberto','elvir Godot','Clinica 7',80000.27,1,1,1,'circunvalacion calle 5b local 456','N')
insert into dbo.MedicoTBL(med_Colegiacion,med_Nombres,med_Apellidos,med_LugTrabajo,med_Honorarios,med_pais,med_ciudad,med_Depto,med_Detalledir,med_redSeg)
values('5618-2015-TG','Alejandro Magno','Andino Vasquez','Clinica 9',90000.27,1,1,1,'circunvalacion calle 31q local 5524','S')

SELECT * from dbo.MedicoTBL
-- REGISTROS POLIZAS
insert into dbo.PolizaTBL(
polz_AsegCodigo,polz_NumCert,polz_Tipo,polz_FechIni,polz_FechFin,polz_MaxHab,polz_Deducible,polz_Coseguro,polz_Maternidad,polz_Farmacia,
polz_Lab_Rayosx,polz_Otros,polz_segVida,polz_serFunebres)
values(1,12,'A1','2015-12-30','2018-12-30',40000,500000,40,'N',25,25,10,500000,65000)

insert into dbo.PolizaTBL(
polz_AsegCodigo,polz_NumCert,polz_Tipo,polz_FechIni,polz_FechFin,polz_MaxHab,polz_Deducible,polz_Coseguro,polz_Maternidad,polz_Farmacia,
polz_Lab_Rayosx,polz_Otros,polz_segVida,polz_serFunebres)
values(2,15,'B','2017-11-01','2018-12-30',50000,1000000,40,'S',25,25,10,600000,70000)

insert into dbo.PolizaTBL(
polz_AsegCodigo,polz_NumCert,polz_Tipo,polz_FechIni,polz_FechFin,polz_MaxHab,polz_Deducible,polz_Coseguro,polz_Maternidad,polz_Farmacia,
polz_Lab_Rayosx,polz_Otros,polz_segVida,polz_serFunebres)
values(3,125,'C','2013-12-30','2017-12-30',70000,500000,40,'S',25,25,10,700000,100000)

insert into dbo.PolizaTBL(
polz_AsegCodigo,polz_NumCert,polz_Tipo,polz_FechIni,polz_FechFin,polz_MaxHab,polz_Deducible,polz_Coseguro,polz_Maternidad,polz_Farmacia,
polz_Lab_Rayosx,polz_Otros,polz_segVida,polz_serFunebres)
values(4,152,'AB','2017-12-30','2018-01-01',80000,900000,40,'S',25,25,10,800000,60000)

insert into dbo.PolizaTBL(
polz_AsegCodigo,polz_NumCert,polz_Tipo,polz_FechIni,polz_FechFin,polz_MaxHab,polz_Deducible,polz_Coseguro,polz_Maternidad,polz_Farmacia,
polz_Lab_Rayosx,polz_Otros,polz_segVida,polz_serFunebres)
values(5,512,'A1','2016-12-30','2018-08-30',40000,700000,40,'N',25,25,10,500000,65000)
SELECT * from dbo.AseguradosTBL order by Aseg_Codigo
-- REGISTROS DEPENDIENTES
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(1,2,'Maria Berta','Castillo Rodriguez','1950-3-12',165,150,'Madre','F')
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(1,2,'Juan Tomas','Palma Rodriguez','1940-05-10',175,180,'Padre','M')
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(2,3,'Maria Eufenia','Rodriguez Hernandez','1953-4-12',165,130,'Madre','F')
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(2,3,'Jose Calo','Castillo Andino','1940-3-12',170,200,'Padre','M')
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(3,4,'Bilma Maria','Rodriguez Rodriguez','1950-3-12',175,200,'Madre','F')
insert into dbo.DependientesTBL(Aseg_CodigoD,polz_IdD,dep_Nombre,dep_Apellido,dep_FechaNac,dep_Estatura,dep_Peso,dep_Parentesco,dep_genero)
values(3,4,'Juan Carlos','Baca Godoy','1944-3-12',175,200,'Padre','M')

-- REGISTROS RECLAMOS POR ACCIDENTE

insert into dbo.RecAccidenteTBL(Acc_Aseg_Codigo,Acc_med_IntCod,Acc_Fecpresentacion,Acc_Monto,Acc_fecha,Acc_horaSuc,Acc_ciudad,Acc_direccion,Acc_Detalle)
values(1,1,'2018-5-07',90000,'2018-5-03','5:55:34.0000','1','Calle 24 frente a torre metroolis','choque automovilistico')
insert into dbo.RecAccidenteTBL(Acc_Aseg_Codigo,Acc_med_IntCod,Acc_Fecpresentacion,Acc_Monto,Acc_fecha,Acc_horaSuc,Acc_ciudad,Acc_direccion,Acc_Detalle)
values(2,4,'2018-10-27',2000,'2018-10-23','15:59:34.0000','1','en domicilio','caida de escaleras,brazo fracturado')
insert into dbo.RecAccidenteTBL(Acc_Aseg_Codigo,Acc_med_IntCod,Acc_Fecpresentacion,Acc_Monto,Acc_fecha,Acc_horaSuc,Acc_ciudad,Acc_direccion,Acc_Detalle)
values(3,3,'2018-11-17',20000,'2018-11-15','13:56:34.0000','1','en domicilio','Quemadura, reventando cuetes')
insert into dbo.RecAccidenteTBL(Acc_Aseg_Codigo,Acc_med_IntCod,Acc_Fecpresentacion,Acc_Monto,Acc_fecha,Acc_horaSuc,Acc_ciudad,Acc_direccion,Acc_Detalle)
values(4,2,'2018-12-16',5000,'2018-12-16','22:52:34.0000','1','Comayaguela 3 Avenida frente SANAA','Punhalada ,Intento de asalto')
insert into dbo.RecAccidenteTBL(Acc_Aseg_Codigo,Acc_med_IntCod,Acc_Fecpresentacion,Acc_Monto,Acc_fecha,Acc_horaSuc,Acc_ciudad,Acc_direccion,Acc_Detalle)
values(5,1,'2018-10-13',280000,'2018-10-10','19:53:34.0000','1','Tiloarque,Frente Inst. Central Vicente Caceres','choque automovilistico,por ir viendo chicas')

-- REGISTROS RECLAMOS POR MATERNIDAD
insert into dbo.RecMaternidadTBL(mat_Aseg_Codigo,mat_med_IntCod,mat_Fecpresentacion,mat_Monto,mat_fechaIn,mat_fechaParto,mat_prevAbort,mat_detalles)
values(1,1,'2018-01-10',2000,'2018-01-5','2018-10-10',1,'control prenatal')
insert into dbo.RecMaternidadTBL(mat_Aseg_Codigo,mat_med_IntCod,mat_Fecpresentacion,mat_Monto,mat_fechaIn,mat_fechaParto,mat_prevAbort,mat_detalles)
values(3,2,'2018-01-10',2000,'2018-01-5','2018-10-10',1,'Aborto espontaneo')
insert into dbo.RecMaternidadTBL(mat_Aseg_Codigo,mat_med_IntCod,mat_Fecpresentacion,mat_Monto,mat_fechaIn,mat_fechaParto,mat_prevAbort,mat_detalles)
values(6,3,'2018-01-10',2000,'2018-01-5','2018-10-10',0,'Cesarea')
insert into dbo.RecMaternidadTBL(mat_Aseg_Codigo,mat_med_IntCod,mat_Fecpresentacion,mat_Monto,mat_fechaIn,mat_fechaParto,mat_prevAbort,mat_detalles)
values(7,4,'2018-01-10',2000,'2018-01-5','2018-10-10',0,'control prenatal')
insert into dbo.RecMaternidadTBL(mat_Aseg_Codigo,mat_med_IntCod,mat_Fecpresentacion,mat_Monto,mat_fechaIn,mat_fechaParto,mat_prevAbort,mat_detalles)
values(7,4,'2018-01-10',2000,'2018-01-5','2018-10-10',1,'operacion Uterina despues de parto')

-- REGISTROS RECLAMOS POR ENFERMEDAD
insert into dbo.recEnfermedadTBL(enf_Aseg_Codigo,enf_med_IntCod,enf_Fecpresentacion,enf_Monto,enf_fechConsulta,enf_fechIniSintomas,enf_sintomas,enf_detalles)
values(1,1,'2018-5-1',3000,'2018-5-1','2018-4-1','Resfriado,congestionNasal,Diarrea,Gorronea','diabetes en familia')
insert into dbo.recEnfermedadTBL(enf_Aseg_Codigo,enf_med_IntCod,enf_Fecpresentacion,enf_Monto,enf_fechConsulta,enf_fechIniSintomas,enf_sintomas,enf_detalles)
values(2,2,'2018-5-1',3000,'2018-5-1','2018-3-1','Migraña,Vomito,Diarrea','paciente con antecedentes leusemicos')
insert into dbo.recEnfermedadTBL(enf_Aseg_Codigo,enf_med_IntCod,enf_Fecpresentacion,enf_Monto,enf_fechConsulta,enf_fechIniSintomas,enf_sintomas,enf_detalles)
values(3,3,'2018-5-1',3000,'2018-5-1','2018-3-1','estreñimiento,dolor de cabeza','Colon Irritable')
insert into dbo.recEnfermedadTBL(enf_Aseg_Codigo,enf_med_IntCod,enf_Fecpresentacion,enf_Monto,enf_fechConsulta,enf_fechIniSintomas,enf_sintomas,enf_detalles)
values(5,4,'2018-5-1',3000,'2018-5-1','2018-1-1','Ritmo cardiaco Acelerado,respiracion corta,Diarrea,Gorronea','cardiopatia en familia')
insert into dbo.recEnfermedadTBL(enf_Aseg_Codigo,enf_med_IntCod,enf_Fecpresentacion,enf_Monto,enf_fechConsulta,enf_fechIniSintomas,enf_sintomas,enf_detalles)
values(6,1,'2018-5-1',3000,'2018-5-1','2015-4-1','Resfriado,congestionNasal,arritmia cardiaca','paciente fumador de 25 años')

-- REGISTROS PADECIMIENTOS PARA SEGURADOS Y DEPENDIENTES
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (1,1)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (1,2)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (1,4)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (2,1)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (2,5)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (3,5)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (5,8)
insert into dbo.PadecimientosTBL(Pad_Aseg_Cod,Padecimiento)values (6,7)
select * from dbo.PadecimientosTBL
--REGISTROS PARA TELEFONOS DE ASEGURADOS
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (1,'22345324')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (1,'22345325')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (1,'89765489')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (2,'23458790')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (2,'23456543')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (3,'12431265')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (3,'90876543')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (6,'12095423')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (6,'12345476')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (5,'22334488')
insert into dbo.TelefonosAseg(Aseg_Codigo,Telefono) values (5,'99886543')
go

--REGISTROS PARA CORREOS DE ASEGURADOS
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (1,'key@claro.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (1,'kyn@outlook.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (2,'jose24@yahoo.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (2,'jos@outlook.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (3,'keyba@hotmail.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (5,'ismael@outlook.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (5,'jose@abc.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (6,'tati@outlook.com')
insert into dbo.EmailsAseg(e_Aseg_Codigo,e_mail)values (8,'tombra@gmail.com')


--REGISTROS PARA TELEFONOS DE MEDICOS
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(1,'23446667')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(1,'32342111')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(2,'98898888')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(2,'22345678')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(3,'45657890')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(3,'33224466')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(4,'11774422')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(4,'22334400')
insert into dbo.TelefonosMed(Med_Codigo,Telefono)values(0,'34544321')
go

--REGISTROS PARA CORREOS DE MEDICOS
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(1,'mau@outlook.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(1,'mauvar@medired.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(2,'bertaes@outlook.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(2,'espinozaber@medired.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(3,'jotu@outlook.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(3,'jorgetur@medired.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(4,'carloselvi@outlook.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(4,'elvirgodoy@medired.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(0,'alejan@outlook.com')
insert into dbo.EmailsMed(e_Aseg_Codigo,e_mail)values(0,'magnoalejandro@medired.com')

--REGISTROS ESPECIALIDADES DE MEDICOS
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(1,2)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(1,1)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(2,1)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(2,6)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(3,1)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(3,3)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(4,1)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(4,5)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(0,1)
insert into dbo.Especialidadesmed(esp_MedCodigo,Especialidad)values(0,2)