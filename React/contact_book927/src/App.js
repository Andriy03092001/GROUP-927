import React, { Component, Fragment } from 'react';
import './App.css';
import ContactItem from './components/contact-item/contact-item'

class App extends Component {

  render() {
    return (
      <Fragment>
        <h2>First react app</h2>
        <ul>
          <li><ContactItem></ContactItem></li>
          <li><ContactItem></ContactItem></li>
        </ul>
      </Fragment>
    )
  }

}

export default App;