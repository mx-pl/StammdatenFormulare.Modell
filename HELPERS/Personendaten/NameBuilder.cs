/*
 ---------------------------------------------------------------------------
  Copyright (c) 2024 mx-pl

  Unter MIT Lizenz veröffentlicht. / Licensed under the MIT License.
  
  Das heißt vor allem (hier nur zur Orientierung; es gilt der volle Lizenztext):
  
  * Ich stelle die Software so wie sie ist zur Verfügung – OHNE Garantie oder Haftung.
  * Vervielfältigung und Weiterverteilung (auch in abgeänderter Form) ist erlaubt, jedoch
  * müssen der Copyright- und Lizenztext allen Kopien beigefügt werden.

  Vollständiger Lizenztext einsehbar unter:
  https://github.com/mx-pl/StammdatenFormulare.Modell/blob/main/LICENSE
 ---------------------------------------------------------------------------
*/

using ExtendedTypes.String;
using StammdatenFormulare.Modell.Personendaten;
using System.Text;

namespace StammdatenFormulare.Modell.HELPERS.Personendaten
{
    /// <summary>
    /// Stellt Methoden bereit zur Generierung des vollen Namens aus Vorname und Nachname.
    /// </summary>
    internal static class NameBuilder
    {
        /// <summary>
        /// Erstellt den vollen Namen aus <paramref name="vorname"/> und <paramref name="nachname"/>,
        /// getrennt durch ein Leerzeichen.
        /// </summary>
        /// <returns>
        /// Den vollen Namen als <see cref="string"/>.
        /// </returns>
        public static string Build(string vorname, string nachname)
        {
            var builder = new StringBuilder();

            if (vorname.IsNotNullOrWhiteSpace())
                builder.Append(vorname);

            if (builder.Length > 0)
                builder.Append(" ");

            if (nachname.IsNotNullOrWhiteSpace())
                builder.Append(nachname);

            return builder.ToString();
        }

        /// <summary>
        /// Erstellt den vollen Namen aus <see cref="NameSchlicht.Vorname"/> und <see cref="NameSchlicht.Nachname"/>,
        /// getrennt durch ein Leerzeichen.
        /// </summary>
        /// <returns>
        /// Den vollen Namen als <see cref="string"/>.
        /// </returns>
        public static string Build(NameSchlicht name)
        {
            return Build(name.Vorname, name.Nachname);
        }
    }
}
