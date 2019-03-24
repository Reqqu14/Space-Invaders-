namespace ProgramZaliczeniowy
{
    interface IUstawialny
    {
        void UstawPozycjeStartowa(int x, int y);
        void UstawPozycjeStartowa(int x, int y, Potwor gracz);
    }
}