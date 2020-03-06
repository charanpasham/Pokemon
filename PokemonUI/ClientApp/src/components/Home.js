import React, { Component } from 'react';

export class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      data : null,
      pokemon: [],
    }
  }
  static displayName = Home.name;

  componentDidMount(){
    var tempPokemon = [];
    const {pokemon} = this.state;
    if(pokemon.length === 0){
      fetch("/api/pokemon/list/1/10", {method: "GET", headers: {
        'Content-Type': 'application/json',
      }})
      .then(response => response.json())
          .then(data => {
          data.forEach(d => {
                  tempPokemon = [
                      ...tempPokemon, { sprites: d.sprites.front_default, name: d.name, pokemonId: d.pokemonId }
                  ];
                  this.setState({ pokemon: tempPokemon });
              });
      });
    }
  }


  render () {
    const { pokemon } = this.state;
    const pokemonList = pokemon && pokemon.map((element, index) => (
      <div style={{ padding: '1rem', margin: '1rem', border: '0.2rem solid pink' }}>
        <img src={element.sprites} alt='pokemon image' />
        <p>{element.name}</p>
        <p>#{element.pokemonId}</p>
      </div>
    ));
    return (
      <div>
        {pokemonList}
      </div>
    );
  }
}
