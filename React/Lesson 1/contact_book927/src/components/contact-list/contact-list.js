import React, { Fragment } from 'react';
import ContactItem from '../contact-item/contact-item';

const ContactList = ({ contacts }) => {

    var contactsTemplate;
    if (contacts !== null) {
        contactsTemplate = contacts.map(item => {
            return (
                <ContactItem
                    name={item.name}
                    number={item.number}
                    gender={item.gender}
                    image={item.image}
                ></ContactItem>
            )
        })
    }

    return (
        <Fragment>
            {contactsTemplate} {/*<-- тут колекція ContactItem з різними даними */}
        </Fragment>
    )
}



export default ContactList;