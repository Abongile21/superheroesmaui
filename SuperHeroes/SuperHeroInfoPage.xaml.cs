using Models;

namespace SuperHeroes;

public partial class SuperHeroInfoPage : ContentPage
{
	public SuperHeroInfoPage(SuperHero superHero)
	{
		InitializeComponent();

		BindingContext = superHero;

	}
}