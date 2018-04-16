/*
SQLyog Ultimate v10.42 
MySQL - 5.1.36-community-log : Database - db_indomart
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_indomart` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_indomart`;

/*Table structure for table `t_karyawan` */

DROP TABLE IF EXISTS `t_karyawan`;

CREATE TABLE `t_karyawan` (
  `Nik` varchar(10) NOT NULL,
  `Nama_Karyawan` varchar(30) DEFAULT NULL,
  `Jenis_Kelamin` varchar(10) DEFAULT NULL,
  `ttl` varchar(30) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `Agama` varchar(10) DEFAULT NULL,
  `Pendidikan` varchar(10) NOT NULL,
  `Jabatan` varchar(22) DEFAULT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`Nik`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `t_karyawan` */

insert  into `t_karyawan`(`Nik`,`Nama_Karyawan`,`Jenis_Kelamin`,`ttl`,`tgl_lahir`,`Agama`,`Pendidikan`,`Jabatan`,`password`) values ('2009012345','Ahmad Subarja','Laki-Laki','Bandung','2013-06-20','Islam','SMA','Kasir','ahmad'),('2009401418','Eris Diansyah','Laki-Laki','Bandung','2013-06-23','Islam','SMA','Kepala Toko','eris'),('2010204156','Siti','Perempuan','Bandung','2013-06-22','Islam','SMA','Asissten Kepala ','ladud'),('2010205196','Rudi M','Laki-Laki','Bandung','2013-06-29','Islam','SMA','MD1',''),('20110909','Maman','Laki-Laki','Bandung','2013-06-25','Islam','SMA','Kasir','maman'),('2012021085','Gian Giana','Laki-Laki','Bandung','2013-06-21','Islam','DIII','Staff','gian'),('9090909','Nurhalim','Laki-Laki','Bandung','2013-06-25','Islam','SMA','Kepala Toko',''),('90990','Nurhalim','Laki-Laki','Bandung','2013-06-25','Islam','SMA','Kepala Toko','');

/*Table structure for table `t_penggajian` */

DROP TABLE IF EXISTS `t_penggajian`;

CREATE TABLE `t_penggajian` (
  `Nik` varchar(10) DEFAULT NULL,
  `gaji_pokok` double DEFAULT NULL,
  `tunjangan` double DEFAULT NULL,
  KEY `Nik` (`Nik`),
  CONSTRAINT `t_penggajian_ibfk_1` FOREIGN KEY (`Nik`) REFERENCES `t_karyawan` (`Nik`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `t_penggajian` */

insert  into `t_penggajian`(`Nik`,`gaji_pokok`,`tunjangan`) values ('2009012345',20000,90),('2009401418',30000,20000);

/*Table structure for table `tb_barang` */

DROP TABLE IF EXISTS `tb_barang`;

CREATE TABLE `tb_barang` (
  `kd_barang` varchar(10) NOT NULL,
  `nama_barang` varchar(30) DEFAULT NULL,
  `jenis_barang` varchar(20) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `tgl_masuk` date DEFAULT NULL,
  `tgl_exp` date DEFAULT NULL,
  `no_rak` varchar(20) DEFAULT NULL,
  `harga_awal` double DEFAULT NULL,
  `harga_akhir` double DEFAULT NULL,
  `harga_jual` double DEFAULT NULL,
  PRIMARY KEY (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_barang` */

insert  into `tb_barang`(`kd_barang`,`nama_barang`,`jenis_barang`,`stock`,`tgl_masuk`,`tgl_exp`,`no_rak`,`harga_awal`,`harga_akhir`,`harga_jual`) values ('B001','Celana','Makanan',-2,'2013-07-01','2013-07-17','MN090',10000,10000,20000),('B002','Baju','Makanan',90,'2013-07-01','2013-07-10','MKNKN90',90000,90000,90000);

/*Table structure for table `tb_keluar` */

DROP TABLE IF EXISTS `tb_keluar`;

CREATE TABLE `tb_keluar` (
  `kd_trans` varchar(11) DEFAULT '001',
  `kd_barang` varchar(10) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` double DEFAULT NULL,
  KEY `tb_temp_keluar_ibfk_1` (`kd_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_keluar` */

insert  into `tb_keluar`(`kd_trans`,`kd_barang`,`tanggal`,`jumlah`,`total`) values ('1001','B001','2013-07-01',10,200000),('1002','B001','2013-07-01',10,200000),('1002','B001','2013-07-01',2,40000);

/*Table structure for table `tb_temp_keluar` */

DROP TABLE IF EXISTS `tb_temp_keluar`;

CREATE TABLE `tb_temp_keluar` (
  `kd_trns` varchar(11) DEFAULT '001',
  `kd_barang` varchar(10) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` double DEFAULT NULL,
  KEY `tb_temp_keluar_ibfk_1` (`kd_barang`),
  CONSTRAINT `tb_temp_keluar_ibfk_1` FOREIGN KEY (`kd_barang`) REFERENCES `tb_barang` (`kd_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_temp_keluar` */

/*Table structure for table `tb_transaksi_keluar` */

DROP TABLE IF EXISTS `tb_transaksi_keluar`;

CREATE TABLE `tb_transaksi_keluar` (
  `kd_trans` varchar(10) NOT NULL,
  `Nik` varchar(10) DEFAULT NULL,
  `tgl` date DEFAULT NULL,
  `total_harga` double DEFAULT NULL,
  PRIMARY KEY (`kd_trans`),
  KEY `tb_transaksi_keluar_ibfk_1` (`Nik`),
  CONSTRAINT `tb_transaksi_keluar_ibfk_1` FOREIGN KEY (`Nik`) REFERENCES `t_karyawan` (`Nik`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tb_transaksi_keluar` */

insert  into `tb_transaksi_keluar`(`kd_trans`,`Nik`,`tgl`,`total_harga`) values ('1001','2009012345','2013-07-01',200000),('1002','2009012345','2013-07-01',240000);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
