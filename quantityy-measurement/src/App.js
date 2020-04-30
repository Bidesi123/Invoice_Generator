import React, { Component } from 'react';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom'
import logo from './logo.svg';
import Home from './pages/Home';
import './App.css';

class App extends Component {
  constructor(props){
    super(props);
  }
  render(){
    return (
      <Router>      
        <Switch>
          <Route path='/' component={Home} exact/>
        </Switch>
      </Router>
    )
  }
}

export default App;
