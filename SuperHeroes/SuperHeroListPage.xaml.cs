

using Models;

namespace SuperHeroes;

public partial class SuperHeroListPage : ContentPage
{
	private List<SuperHero> _superHeroes;
	public SuperHeroListPage()
	{
		InitializeComponent();
		MakeSuperHeroes();
		SuperHeroesListView.ItemsSource = _superHeroes;
	}

	private void MakeSuperHeroes()
	{
		_superHeroes = new List<SuperHero>();

		SuperHero superHero = new SuperHero("Batman", "Bruce Wayne", "Tech Billionaire", false, 0, "batmansmall.png");
		_superHeroes.Add(superHero);

        superHero = new SuperHero("Deadpool", "Wade Wilson", "Tech Billionaire", false, 0, "deadpool.jpeg");
        _superHeroes.Add(superHero);
    }
}