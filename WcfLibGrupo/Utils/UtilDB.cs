using ManagerDBLibrary;
using ServicosSysFileManager;
using System;
using WcfLibGrupo.Utils;

namespace WcfLibGrupo
{
    public class UtilDB
    {
        private static string fileOutputBackupSql = String.Format(UtilsSistemaServico.SUBDIR_BACKUP + @"backupSystem{0:yyyy-MM-dd_HH-mm}_temp.sql", new ServiceGrupo().retornaDataHoraLocal());
        private static string fileOutputBackupCrypt = String.Format(UtilsSistemaServico.SUBDIR_BACKUP + @"backupSystem{0:yyyy-MM-dd_HH-mm}.syscrypt", new ServiceGrupo().retornaDataHoraLocal());
        private static string fileRestoreBackupSql = String.Format(UtilsSistemaServico.SUBDIR_TEMP_FILES + @"backupTemp.sql");

        public string createBackup(string host, string port, string username, string role, string format,
            string section, string encoding, string database, string password)
        {
            try
            {
                new ManageLibrary().createBackupDB(host, port, username, role, format, section, encoding, fileOutputBackupSql, database);
                new ManageLibrary().encryptFile(fileOutputBackupSql, fileOutputBackupCrypt, password);
                new SysFile().excluirArquivo(fileOutputBackupSql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fileOutputBackupCrypt;
        }

        public bool restoreBackup(string host, string port, string username, string fileInput, string database, string password)
        {
            bool _return = false;
            try
            {
                new ManageLibrary().decryptFile(fileInput, fileRestoreBackupSql, password);
                new ManageLibrary().restoreDB(host, port, username, fileRestoreBackupSql, database);
                new SysFile().excluirArquivo(fileRestoreBackupSql);
                _return = true;
            }
            catch (Exception ex)
            {
                _return = false;
                throw new Exception(ex.Message);
            }
            return _return;
        }
    }
}
