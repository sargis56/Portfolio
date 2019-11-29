const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const TipSchema = new Schema({
    created: {
        type: Date,
        default: Date.now
    },
    dTip:{
        type: String,
        default: '',
        trim: true,
        required: 'Tip cannot be blank'
    },
    creator: {
        type: Schema.ObjectId,
        ref: 'User'
    }
});

mongoose.model('TipDB', TipSchema);
