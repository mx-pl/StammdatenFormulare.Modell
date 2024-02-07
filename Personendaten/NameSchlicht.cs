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

using StammdatenFormulare.Modell.HELPERS.Personendaten;

namespace StammdatenFormulare.Modell.Personendaten
{
    /// <summary>
    /// Der Name einer Person, bestehend aus Vorname(n) und Nachname(n).
    /// </summary>
    /// <param name="Vorname">Der oder die Vorname(n) der Person.</param>
    /// <param name="Nachname">Der oder die Nachname(n) der Person.</param>
    public readonly record struct NameSchlicht(string Vorname, string Nachname)
    {
        /// <summary>
        /// Der volle Name bestehend aus Vorname und Nachname;
        /// getrennt durch ein Leerzeichen.
        /// </summary>
        public string VollerName => NameBuilder.Build(this);
    }
}
