using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class Surat
    {
        string idSurat, hal, npm, keterangan, alamat, tanggalInput, tanggalAmbil, tanggalWisuda, tanggalTesis;
        int idStaffInput, idStaffAmbil, mataKuliah, idStatus;


        public Surat(string idSurat, string hal, string npm, string tanggalInput, string tanggalAmbil, string keterangan, string tanggalWisuda, string tanggalTesis, int mataKuliah, string alamat, int idStaffInput, int idStaffAmbil, int idStatus)
        {
            this.idSurat = idSurat;
            this.hal = hal;
            this.npm = npm;
            this.tanggalInput = tanggalInput;
            this.tanggalAmbil = tanggalAmbil;
            this.keterangan = keterangan;
            this.tanggalWisuda = tanggalWisuda;
            this.tanggalTesis = tanggalTesis;
            this.mataKuliah = mataKuliah;
            this.alamat = alamat;
            this.idStaffInput = idStaffInput;
            this.idStaffAmbil = idStaffAmbil;
            this.idStatus = idStatus;
        }

        public int IDStaffInput
        {
            get { return idStaffInput; }
            set { idStaffInput = value; }
        }

        public int IDStaffAmbil
        {
            get { return idStaffAmbil; }
            set { idStaffAmbil = value; }
        }

        public int IDStatus
        {
            get { return idStatus; }
            set { idStatus = value; }
        }

        public int MataKuliah
        {
            get { return mataKuliah; }
            set { mataKuliah = value; }
        }

        public string IDSurat
        {
            get { return idSurat; }
            set { idSurat = value; }
        }

        public string Hal
        {
            get { return hal; }
            set { hal = value; }
        }

        public string NPM
        {
            get { return npm; }
            set { npm = value; }
        }

        public string TanggalInput
        {
            get { return tanggalInput; }
            set { tanggalInput = value; }
        }

        public string TanggalAmbil
        {
            get { return tanggalAmbil; }
            set { tanggalAmbil = value; }
        }

        public string TanggalWisuda
        {
            get { return tanggalWisuda; }
            set { tanggalWisuda = value; }
        }

        public string TanggalTesis
        {
            get { return tanggalTesis; }
            set { tanggalTesis = value; }
        }

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }
    }
}
