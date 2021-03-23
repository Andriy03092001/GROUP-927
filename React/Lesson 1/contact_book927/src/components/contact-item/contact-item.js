import React, { Component, Fragment } from 'react';
import './contact-item.css';

class ContactItem extends Component {

    state = {
        name: this.props.name,
        number: this.props.number,
        image: this.props.image,
        gender: this.props.gender,
        isFavorite: false
    }

    setRandomImage = () => {
        var randomAvatar = Math.floor(Math.random() * Math.floor(99));
        this.setState({
            image: randomAvatar
        })
    }

    //npx create-react-app project_name

    chnageFavorite = () => {
        this.setState({
            isFavorite: !this.state.isFavorite
        })
        console.log("isFavorite: ", this.state.isFavorite)
    }

    render() {
        const { name, number, image, gender } = this.state;
        const image_URL = `https://randomuser.me/api/portraits/${gender}/${image}.jpg`;

        var class_star = "favorite far fa-star fa-2x";
        if (this.state.isFavorite === true) {
            class_star = "favorite fas fa-star fa-2x"
        }

        return (
            <div className="card col-4" >
                <img className="card-img-top" src={image_URL} alt="Card image cap" />
                <div className="card-body">
                    <h2 className="card-title">{name}</h2>
                    <p className="card-text">{number}</p>
                </div>
                <div className="card-footer">
                    <button onClick={this.setRandomImage} className="btn btn-info">Random image</button>
                    <i onClick={this.chnageFavorite} className={class_star}></i>
                </div>
            </div>
        )
    }
}

export default ContactItem;