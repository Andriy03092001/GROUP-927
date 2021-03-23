import React, { Component, Fragment } from 'react';
import { Route, Switch } from 'react-router';
import SignUp from './components/sign-up';
import SignIn from './components/sign-in';
// import "./index.css";

export default class App extends Component {

  render() {
    return (
      <Fragment>
        <h2>Student poject</h2>

        <Switch>
          <Route exact path='/' component={SignIn} />
          <Route path='/sign-up' component={SignUp} />
        </Switch>
      </Fragment>
    );
  }
}


