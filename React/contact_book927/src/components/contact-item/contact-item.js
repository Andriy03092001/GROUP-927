import React, { Component, Fragment } from 'react';
import './contact-item.css';

class ContactItem extends Component {

    state = {
        name: "Andrii Riabii",
        number: "+38 (095) 41 66 765",
        image: "https://image.shutterstock.com/image-vector/young-man-avatar-character-260nw-661669825.jpg"
    }

    render() {
        const { name, number, image } = this.state;
        return (
            <Fragment>
                <img width="200px" src={image} />
                <h2>{name}</h2>
                <small>{number}</small>
            </Fragment>
        )
    }
}

export default ContactItem;