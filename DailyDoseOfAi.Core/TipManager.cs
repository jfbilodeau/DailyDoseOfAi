namespace DailyDoseOfAi.Core;

public class TipManager
{
    private readonly List<Tip> _tips = new()
    {
        new Tip(
            "Copilot: Amicus Optimus Tuus",
            "Copilot est tamquam senioris programmatoris: numquam dormit, numquam conqueritur, numquam iudicat nomina variabilium tuorum. Bene, revera iudicat, sed ad HR non narrabit."
        ),
        new Tip(
            "Magia Explicandi",
            "Usa praeceptum /explain Copiloti ut intellegas codicem quem sex menses antea scripsi. Monitio: num reminerisceris cur ita scripseris."
        ),
        new Tip(
            "Animadversiones: Epistolae Amoris Tuae",
            "Scribe animadversiones pro futuro te. Monitus: futurus tuus se odio habitum erit praeterito tuo, igitur saltem conare."
        ),
        new Tip(
            "Roga Copilot Quodvis",
            "Copilot auxilium praestare potest cum codice, probationibus, documentatione, et emendatione. Tantum ne roga ut epistolas amoris scribat. (Fortasse ne quaecumque nimis personalia rogabis)."
        ),
        new Tip(
            "Completa Tabulatione ad Victoriam",
            "Premi Tab ut suggestiones Copiloti accipias. Monitio: fortasse graviter accipies suggestionem quae codicem tuum frangit. Idcirco Ctrl+Z invenerunt."
        ),
        new Tip(
            "Evolutio Probationibus Comota cum Copilot",
            "Sine Copilot probationes tuorum scribere dum tu potionem bibis. Monitio: probationes tuae benignae nimis esse possunt, sed saltem existent!"
        ),
        new Tip(
            "Nominatio Rerum (Difficilissimum Problema)",
            "Copilot auxilium praestare potest cum nominibus variabilium, ut non finias cum variabilibus 'temp', 'data', vel 'stuff'. Gratias tibi, future tue."
        ),
        new Tip(
            "Potentia Contextus",
            "Da Copiloto contextum de tuo proiecto in animadversionibus. Contextus magis = suggestiones meliores. Similis est differentiae inter 'confer' et 'emenda connexionem databasei tempora exspectationis'."
        ),
        new Tip(
            "Serva Siccum cum Copilot",
            "Noli Repetas Te Ipsum! Sine Copilot adiuvare refactorizationem codi imitati. Tuae commentationes praetexendi gratiam agebunt."
        ),
        new Tip(
            "Programmatio Gemina cum Intelligentia Artificiali",
            "Copilot est tuus programmator geminus indefessus. Non occupat claviaturam, semper in munere permanet, et numquam bibit omnem potionem officii."
        )
    };

    public Tip GetDailyTip()
    {
        int dayOfYear = DateTime.Now.DayOfYear;
        int tipIndex = dayOfYear % _tips.Count;
        return _tips[tipIndex];
    }
}
