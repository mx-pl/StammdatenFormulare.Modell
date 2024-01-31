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

namespace StammdatenFormulare.Modell.Kontaktdaten
{
    /// <summary>
    /// Die Telefonnummer einer Person, eines Unternehmens etc.
    /// </summary>
    /// <param name="Nummer">Telefonnummer als <see cref="string"/>.</param>
    public readonly record struct TelefonnummerSchlicht(string Nummer);
}
