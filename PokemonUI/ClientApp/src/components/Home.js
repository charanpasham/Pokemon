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
    console.log(pokemon.length);
    if(pokemon.length === 0){
      fetch("https://pokeapi.co/api/v2/pokemon?ffset=0&limit=1000", {method: "GET", headers: {
        'Content-Type': 'application/json',
      }})
      .then(response => response.json())
        .then(data=> {
            var result = data.results;
            result.forEach(element => {
              fetch(element.url)
                .then(pokemon => pokemon.json())
                .then(pokemon => {
                  tempPokemon= [ ...tempPokemon, { sprites: pokemon.sprites.front_default, name: pokemon.name } ];
                  //console.log(tempPokemon);
                  this.setState({pokemon: tempPokemon});
                });
            });
            console.log(tempPokemon);
        });
    }

      
      
      //this.setState({ data }));    
  }


  // this.setState((state, props) => (
  //   {
  //    pokemon: [ ...state.pokemon, { sprites: pokemon.sprites.front_default, name: pokemon.name }]
  //   }

  // ))

  render () {
    const { pokemon } = this.state;
    console.log(pokemon);
    const pokemonList = pokemon && pokemon.map((element, index) => (
      <div style={{ padding: '1rem', margin: '1rem', border: '0.2rem solid pink' }}>
        <img src={element.sprites} alt='pokemon image' />
        <p>{element.name}</p>
        <p>#{index+1}</p>
      </div>
    ));
    return (
      <div>
        {pokemonList}
      </div>
    );
  }
}
