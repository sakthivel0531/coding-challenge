import { LoanActions } from '../action/loan-action';

export function rootReducer(state, action) {
    switch (action.type) {
        case LoanActions.addNewLoan:
            return Object.assign({}, state, {});
        case LoanActions.getLoanDetails:
            console.log('i am here');
            console.log(state);
            console.log(action.todo);
            return Object.assign({}, state, {
                loanDetailList: action.loanDetailList,
                totalLoan: state.loanDetailList.length
            });
    }
}
