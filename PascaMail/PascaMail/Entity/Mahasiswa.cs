using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class Mahasiswa
    {
        string nama, npm, tempatLahir, tanggalLahir, agama, jenisKelamin, tahunMasuk, awalStudi, kewarganegaraan;
        int prodi, kaprodi;

        public Mahasiswa(string npm, string nama, int prodi, int kaprodi, string tempatLahir, string tanggalLahir, string agama, string jenisKelamin, string tahunMasuk, string awalStudi, string kewarganegaraan)
        {
            this.npm = npm;
            this.nama = nama;
            this.prodi = prodi;
            this.kaprodi = kaprodi;
            this.tempatLahir = tempatLahir;
            this.tanggalLahir = tanggalLahir;
            this.agama = agama;
            this.jenisKelamin = jenisKelamin;
            this.tahunMasuk = tahunMasuk;
            this.awalStudi = awalStudi;
            this.kewarganegaraan = kewarganegaraan;
        }

        public string NPM
        {
            get { return npm; }
            set { npm = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Prodi
        {
            get { return prodi; }
            set { prodi = value; }
        }

        public int Kaprodi
        {
            get { return kaprodi; }
            set { kaprodi = value; }
        }

        public string TempatLahir
        {
            get { return tempatLahir; }
            set { tempatLahir = value; }
        }

        public string TanggalLahir
        {
            get { return tanggalLahir; }
            set { tanggalLahir = value; }
        }

        public string Agama
        {
            get { return agama; }
            set { agama = value; }
        }

        public string JenisKelamin
        {
            get { return jenisKelamin; }
            set { jenisKelamin = value; }
        }

        public string TahunMasuk
        {
            get { return tahunMasuk; }
            set { tahunMasuk = value; }
        }

        public string AwalStudi
        {
            get { return awalStudi; }
            set { awalStudi = value; }
        }

        public string Kewarganegaraan
        {
            get { return kewarganegaraan; }
            set { kewarganegaraan = value; }
        }
        
    }
}
