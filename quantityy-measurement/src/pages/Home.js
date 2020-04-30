import React, { Component } from 'react'
import axios from 'axios'

class Home extends Component {
    constructor(props) {
        super(props)
        this.state = {
            inputUnit: '',
            outputUnit:'',
            unitNumber: parseInt('0'),
            outPutValue:parseInt('0')
        }
    }

    inputValue = (event) => {
        this.setState({unitNumber:event.target.value}) 
        console.log("unitNumber :"+this.state.unitNumber) ;      
    }

    handleInput = (event) => {
        this.setState(
            {
                inputUnit: event.target.value ,                         
            }
        );    
        console.log(this.state.inputUnit);    
    }

    handleOutput = (event) => {
        this.setState(
            {
                outputUnit: event.target.value              
            }
        );
        console.log(this.state.outputUnit); 
     }

    onClick=(e)=>{
        console.log("outputUnit"+this.state.outputUnit);
        console.log("inputUnit "+this.state.inputUnit);
        console.log("unitNumber :"+this.state.unitNumber) ;
        //Length Unit Axios
        if(this.state.inputUnit==='Feet' && this.state.outputUnit==='Inch'){
            axios.get(`https://localhost:44300/api/Length/api/FeetToInche?feet=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputUnit==='Inch' && this.state.outputUnit==='Feet'){
            axios.get(`https://localhost:44300/api/Length/api/IncheToFeet?inch=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }

        // Temperature Unit Axios

        if (this.state.inputUnit==='Fahrenheith' && this.state.outputUnit==='Celsius'){
            axios.get(`https://localhost:44300/api/Temp/api/FahrenheitToCelcius?fahrenheit=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputUnit==='Celsius' && this.state.outputUnit==='Fahrenheith'){
            axios.get(`https://localhost:44300/api/Temp/api/CelciusToFahrenheit?celcious=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }

        // Weight Unit Axios
        if (this.state.inputUnit==='Kilogram' && this.state.outputUnit==='Gram'){
            axios.get(`https://localhost:44300/api/Weight/api/KgToGm?kg=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputUnit==='Gram' && this.state.outputUnit==='Kilogram'){
            axios.get(`https://localhost:44300/api/Weight/api/GmToKg?gm=${this.state.unitNumber}`)
            .then(response => {
                this.setState({outPutValue:response.data})
                console.log(response.data);
            });
        }
    }

    

    render() {
        
        return (
            <>
                <div id='Main-div' className='container'>
                    <div className='container'>
                        <div className='headline-div'>
                            <h1 className='head1'>WELCOME</h1>
                            <h1 className='head2'>QUANTITY CALCULATION</h1>
                        </div>
                        <div className='length-wt-temp-opt-div'>           
                            <select className='unit-select' onChange={this.MainOnChange}>
                                <option value='Length'>Length</option>
                                <option value='Weight'>Weight</option>
                                <option value='Temperature'>Temperature</option>
                            </select>
                        </div>
                        <div className='covert-div'>
                            <div className='input-div'>
                                <input type='text' placeholder='text' onChange={this.inputValue} value={this.state.unitNumber}></input>
                                <select className='i-o-select' value={this.state.value} onChange={this.handleInput}>
                                    <option value='Inch'>Inch</option>
                                    <option value='Feet'>Feet</option>
                                    <option value='Kilogram'>Kilogram</option>
                                    <option value='Gram'>Gram</option>
                                    <option value='Celsius'>Celsius</option>
                                    <option value='Fahrenheith'>Fahrenheith</option>
                                </select>
                            </div>
                            <div className='equal-sign-div'>
                                <h1>=</h1>
                            </div>
                            <div className='output-div'>
                                <input type='text' value={this.state.outPutValue }></input>
                                <select className='i-o-select' value={this.state.value} onChange={this.handleOutput}>
                                    <option value='Inch'>Inch</option>
                                    <option value='Feet'>Feet</option>
                                    <option value='Kilogram'>Kilogram</option>
                                    <option value='Gram'>Gram</option>
                                    <option value='Celsius'>Celsius</option>
                                    <option value='Fahrenheith'>Fahrenheith</option>
                                </select>
                            </div>
                        </div>
                        <div>
                            <button className='submit-btn' type='submit' value='Submit' onClick={this.onClick}>Submit</button>
                        </div>
                    </div>
                </div>
            </>
        )
    }

}
export default Home
