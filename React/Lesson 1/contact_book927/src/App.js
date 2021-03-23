import React, { Component, Fragment } from 'react';
import './App.css';
import ContactItem from './components/contact-item/contact-item'
import Navbar from './components/navbar/navbar';
import AddContact from './components/addContact/addContact';
import ContactList from './components/contact-list/contact-list';

class App extends Component {

  state = {
    contacts: [
      {
        name: "Andrii Riabii",
        number: "+38 (095) 41 66 765",
        image: 67,
        gender: "men"
      },
      {
        name: "Vika Zakoyuk",
        number: "+38 (097) 77 77 777",
        image: 3,
        gender: "women"
      },
      {
        name: "Vitalik Oleksiychuk",
        number: "+38 (093) 54 13 876",
        image: 70,
        gender: "men"
      },
      {
        name: "Sofia Fedorchuk",
        number: "+38 (093) 17 13 876",
        image: 13,
        gender: "women"
      }
    ]
  }

  addContact = (newContact) => {
    var tempContacts = [];
    if (this.state.contacts != null) {
      tempContacts = this.state.contacts.slice();
    }
    tempContacts.push(newContact);

    this.setState({
      contacts: tempContacts
    })
  }


  render() {
    return (
      <Fragment>

        <Navbar></Navbar>
        <div className="container-fluid">
          <div className="row">
            <div className="col-2">
              <h3>Add new contact:</h3>
              <AddContact addContact={this.addContact}></AddContact>
            </div>
            <div className="col-10">
              <div className="row">
                <ContactList contacts={this.state.contacts}></ContactList>
              </div>
            </div>

          </div>
        </div>
      </Fragment>
    )
  }

}

export default App;