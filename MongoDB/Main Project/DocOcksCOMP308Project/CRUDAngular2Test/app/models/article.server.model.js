const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const ArticleSchema = new Schema({
    created: {
        type: Date,
        default: Date.now
    },
    bodyTemp: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Body temperature cannot be blank'
    },
    patientName: {
        type: String,
        default: '',
        trim: true,
        required: 'Patient name cannot be blank'
    },
    heartRate: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Heart rate cannot be blank'
    },
    bloodPressure: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Blood pressure cannot be blank'
    },
    respiratoryRate: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Respiratory rate cannot be blank'
    },
    dateDay: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Day cannot be blank'
    },
    dateMonth: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Month cannot be blank'
    },
    dateYear: {
        type: Number,
        default: 0,
        trim: true,
        required: 'Year cannot be blank'
    },
    creator: {
        type: Schema.ObjectId,
        ref: 'User'
    }
});

mongoose.model('VitalSigns', ArticleSchema);
