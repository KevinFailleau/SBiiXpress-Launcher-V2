using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Launcher
{
    class Registre
    {
        #region Lecture d'une valeur dans le registre

        /// <summary>
        /// Méthode qui permet de lire une valeur dans le registre
        /// </summary>
        /// <param name="pathLecture">Chemin pour accéder à la valeur</param>
        /// <param name="valName">Nom de la valeur à lire</param>
        /// <returns>Contenu de la valeur</returns>
        public static string LectureValeur(string pathLecture, string valName)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(pathLecture); //On essaie d'ouvrir le chemin spécifié
                if (key != null)
                {
                    Object o = key.GetValue(valName); //Si le chemin existe alors on essaie d'accéder à la valeur
                    if (o != null)
                    {
                        return Convert.ToString(o); //Si la valeur existe bien, on retourne son contenu sous la forme d'une chaîne de caractères
                    }
                }
            }
            catch (Exception ex)
            {
                //En cas d'erreur on affiche le message suivant et l'erreur en question
                MessageBox.Show("L'application a rencontré une erreur lors de l'accès à la base de registre\n" + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "err";
        }

        /// <summary>
        /// Méthode qui permet de lire une valeur dans le registre
        /// </summary>
        /// <param name="pathLecture">Chemin pour accéder à la valeur</param>
        /// <param name="valName">Nom de la valeur à lire</param>
        /// <param name="rV">Type de registre (32 ou 64 bits)</param>
        /// <returns></returns>
        public static string LectureValeur(string pathLecture, string valName, RegistryView rV)
        {
            try
            {
                var basereg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rV); //On spécifie le type de regitre (des différences peuvent exister entre les registre des OS 32 et 64 bits)
                var subKey = basereg.OpenSubKey(pathLecture); //On essaie d'ouvrir le chemin spécifié
                if (subKey != null)
                {
                    Object o = subKey.GetValue(valName); //Si le chemin existe alors on essaie d'accéder à la valeur
                    if (o != null)
                    {
                        return Convert.ToString(o); //Si la valeur existe, on retourne son contenu sous la fome d'une chaîne de caractères
                    }
                }
            }
            catch (Exception ex)
            {
                //En cas d'erreur on affiche le message suivant et l'erreur en question
                MessageBox.Show("L'application a rencontré une erreur lors de la lecture de la base de registre\n" + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "err";
        }
        #endregion

        #region Ecriture d'une valeur

        /// <summary>
        /// Méthode qui permet d'écrire une valeur qui aura pour contenu un entier
        /// </summary>
        /// <param name="path">Chemin pour écrire la valeur à ajouter</param>
        /// <param name="valueName">Nom de la valeur à ajouter</param>
        /// <param name="value">Contenu de la valeur à ajouter</param>
        /// <param name="valueKind">Type de la valeur à ajouter</param>
        /// <param name="rV">Type de resitre (32 ou 64 bits)</param>
        public static void EcrireRegistre(string path, string valueName, int value, RegistryValueKind valueKind, RegistryView rV)
        {
            var baseReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rV); //Ouvre un nouveau RegistryKey qui représente la clé demandée sur l'ordinateur local avec la vue spécifiée.
            var reg = baseReg.CreateSubKey(path); //Création d'une variable avec le chemin spécifié

            try
            {
                reg = baseReg.OpenSubKey(path, true); //On tente d'ouvrir la sous-clé avec le chemin indiqué

                if (reg == null)
                {
                    baseReg.CreateSubKey(path); //Si il est impossible d'ouvrir cette sous-clé, on la crée
                }

                reg.SetValue(valueName, value, valueKind); //Ensuite on défini la valeur, le nom et le type de la valeur pour cette sous-clé
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); //En cas d'erreur, on affiche un message
            }
            finally
            {
                baseReg.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet d'écrire une valeur qui aura pour contenu une chaîne de caractères
        /// </summary>
        /// <param name="path">Chemin pour écrire la valeur à ajouter</param>
        /// <param name="valueName">Nom de la valeur à ajouter</param>
        /// <param name="value">Contenu de la valeur à ajouter</param>
        /// <param name="valueKind">Type de la valeur à ajouter</param>
        /// <param name="rV">Type de registre (32 ou 64 bits)</param>
        public static void EcrireRegistre(string path, string valueName, string value, RegistryValueKind valueKind, RegistryView rV)
        {
            var baseReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rV); //Ouvre un nouveau RegistryKey qui représente la clé demandée sur l'ordinateur local avec la vue spécifiée.
            var reg = baseReg.CreateSubKey(path); //Création d'une variable avec le chemin spécifié

            try
            {
                reg = baseReg.OpenSubKey(path, true); //On tente d'ouvrir la sous-clé avec le chemin indiqué

                if (reg == null)
                {
                    baseReg.CreateSubKey(path); //Si il est impossible d'ouvrir cette sous-clé, on la crée
                }

                reg.SetValue(valueName, value, valueKind); //Ensuite on défini la valeur, le nom et le type de la valeur pour cette sous-clé
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); //En cas d'erreur, on affiche un message
            }
            finally
            {
                baseReg.Close();
            }
        }
        #endregion
    }
}
