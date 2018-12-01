using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PascaMail.dbPascaMailTableAdapters;
using PascaMail.Entity;

namespace PascaMail.Control
{
    class PascaControl
    {
        private TBL_MAHASISWATableAdapter TM = new TBL_MAHASISWATableAdapter();
        private TBL_STAFFTableAdapter TS = new TBL_STAFFTableAdapter();
        private TBL_SURATTableAdapter TSU = new TBL_SURATTableAdapter();
        private TBL_STATUS_SURATTableAdapter TSS = new TBL_STATUS_SURATTableAdapter();
        private TBL_STAFFTableAdapter TST = new TBL_STAFFTableAdapter();
        private TBL_KAPRODITableAdapter TK = new TBL_KAPRODITableAdapter();
        private TBL_PRODITableAdapter TP = new TBL_PRODITableAdapter();
        private TBL_MATA_KULIAHTableAdapter TMK = new TBL_MATA_KULIAHTableAdapter();
        private SuratTableAdapter SRT = new SuratTableAdapter();
        ShowException SE = new ShowException();

        //Control untuk tabel Mahasiswa
        public DataTable showMahasiswa()
        {
            DataTable DT = null;
            try
            {
                DT = TM.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchMahasiswa(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TM.GetDataByMhs(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public bool cekNPM(string npm)
        {
            bool temp = true;

            if (TM.SearchMhs(npm) != null)
            {
                temp = false;
            }
            return temp;
        }

        public void insertMhs(Mahasiswa M)
        {
            try
            {
                TM.InsertMhs(M.NPM, M.Nama, M.Prodi, M.Kaprodi, M.TempatLahir, M.TanggalLahir, M.Agama, M.JenisKelamin, M.TahunMasuk, M.AwalStudi, M.Kewarganegaraan);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateMhs(Mahasiswa M, int id)
        {
            try
            {
                TM.UpdateMhs(M.NPM, M.Nama, M.Prodi, M.Kaprodi, M.TempatLahir, M.TanggalLahir, M.Agama, M.JenisKelamin, M.TahunMasuk, M.AwalStudi, M.Kewarganegaraan, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteMhs(int id)
        {
            try
            {
                TM.DeleteMhs(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
        //----------------------------------//

        //-----Query untuk tabel Surat-----//

        public DataTable showSurat()
        {
            DataTable DT = null;
            try
            {
                DT = TSU.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchSurat(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TSU.GetDataBySurat(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public void inputSurat(Surat S)
        {
            try
            {
                TSU.InsertSurat(S.IDSurat, S.Hal, S.NPM, S.TanggalInput, S.TanggalAmbil, S.Keterangan, S.TanggalWisuda, S.TanggalTesis, S.MataKuliah, S.Alamat, S.IDStaffInput, S.IDStaffAmbil, S.IDStatus);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateSurat(Surat S, int id)
        {
            try
            {
                TSU.UpdateSurat(S.IDSurat, S.Hal, S.NPM, S.TanggalInput, S.TanggalAmbil, S.Keterangan, S.TanggalWisuda, S.TanggalTesis, S.MataKuliah, S.Alamat, S.IDStaffInput, S.IDStaffAmbil, S.IDStatus, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteSurat(string id)
        {
            try
            {
                TSU.DeleteSurat(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public int getCountRowSurat()
        {
            int temp = 0;
            try
            {
                temp = int.Parse(TSU.GetCountRowSurat().ToString());
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }
        //----------------------------------//


        //-----Query untuk tabel Staff-----//
        public DataTable showStaff()
        {
            DataTable DT = null;
            try
            {
                DT = TST.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchStaff(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TST.GetDataByStaff(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable getStaff()
        {
            DataTable DT = null;
            try
            {
                DT = TS.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int getIDStaff(string staff)
        {
            int temp = 0;
            try
            {
                temp = TS.GetIdStaff(staff).Value;
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }

        public void insertStaff(Staff S)
        {
            try
            {
                TST.InsertStaff(S.NamaStaff);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateStaff(Staff S, int id)
        {
            try
            {
                TST.UpdateStaff(S.NamaStaff, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteStaff(int id)
        {
            try
            {
                TST.DeleteStaff(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
        //----------------------------------//


        //-----Query untuk tabel Kaprodi-----//
        public DataTable showKaprodi()
        {
            DataTable DT = null;
            try
            {
                DT = TK.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchKaprodi(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TK.GetDataByKaprodi(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable getKaprodi()
        {
            DataTable DT = null;
            try
            {
                DT = TK.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int getIDKaprodi(string kaprodi)
        {
            int temp = 0;
            try
            {
                temp = TK.GetIdKaprodi(kaprodi).Value;
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }

        public void insertKaprodi(Kaprodi K)
        {
            try
            {
                TK.InsertKaprodi(K.NamaKaprodi, K.Prodi);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateKaprodi(Kaprodi K, int id)
        {
            try
            {
                TK.UpdateKaprodi(K.NamaKaprodi, K.Prodi, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteKaprodi(int id)
        {
            try
            {
                TK.DeleteKaprodi(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
        //----------------------------------//

        //-----Query untuk tabel Status Surat-----//
        public DataTable getStatus()
        {
            DataTable DT = null;
            try
            {
                DT = TSS.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int getIDStatus(string status)
        {
            int temp = 0;
            try
            {
                temp = TSS.GetStatusSurat(status).Value;
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }
        //----------------------------------//

        //-----Query untuk tabel Prodi-----//

        public DataTable showProdi()
        {
            DataTable DT = null;
            try
            {
                DT = TP.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchProdi(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TP.GetDataByProdi(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable getProdi()
        {
            DataTable DT = null;
            try
            {
                DT = TP.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int getIDProdi(string prodi)
        {
            int temp = 0;
            try
            {
                temp = TP.GetIdProdi(prodi).Value;
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }

        public void insertProdi(Prodi P)
        {
            try
            {
                TP.InsertProdi(P.NamaProdi);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateProdi(Prodi P, int id)
        {
            try
            {
                TP.UpdateProdi(P.NamaProdi, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteProdi(int id)
        {
            try
            {
                TP.DeleteProdi(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
        //----------------------------------//

        //

        public DataTable showMakul()
        {
            DataTable DT = null;
            try
            {
                DT = TMK.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable searchMakul(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TMK.GetDataByMakul(keyword);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public DataTable getMakul()
        {
            DataTable DT = null;
            try
            {
                DT = TMK.GetData();
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }

        public int getIDMakul(string makul)
        {
            int temp = 0;
            try
            {
                temp = TMK.GetIdMakul(makul).Value;
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return temp;
        }

        public void insertMakul(MataKuliah  M)
        {
            try
            {
                TMK.InsertMakul(M.NamaMakul, M.NamaDosen, M.Prodi);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void updateMakul(MataKuliah M, int id)
        {
            try
            {
                TMK.UpdateMakul(M.NamaMakul, M.NamaDosen, M.Prodi, id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }

        public void deleteMakul(int id)
        {
            try
            {
                TMK.DeleteMakul(id);
            }
            catch (Exception ex)
            {
                SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
        }
        //----------------------------------//
    }
}
