// import { render, screen, fireEvent, waitFor} from '@testing-library/react';
// import SignUp from './Signup';
// import { BrowserRouter } from 'react-router';
// import '@testing-library/jest-dom'; // <-- make sure this is here
// //mock

// const signupUserMock = jest.fn();

// jest.mock('../hooks/useSignup', () => ({
//   __esModule: true,
//   default: () => ({
//     signupUser: signupUserMock,
//   }),
// }));

// // Setup helper that wraps in <BrowserRouter>
// const setup = () => render(<SignUp />, { wrapper: BrowserRouter});

// test('navigates to login on successful signup', async () => {
//     signupUserMock.mockResolvedValue({});

//     setup();

//     fireEvent.change(screen.getByPlaceholderText('full name'), {
//         target: { value: 'test user'}
//     });

//     fireEvent.change(screen.getByPlaceholderText('username'), {
//         target: { value: 'testuser'},
//     });
    
//     fireEvent.change(screen.getByPlaceholderText('password'), {
//         target: { value: 'password123'},
//     });

//     fireEvent.change(screen.getByPlaceholderText('confirm password'), {
//         target: {value: 'password123'}
//     })

//     const checkbox = screen.getByRole('checkbox', { name: /female/i });

//     expect(checkbox).toBeChecked();

//     fireEvent.click(checkbox)

//     expect(checkbox).toBeChecked();

//     fireEvent.click(screen.getByText('Sign Up'));

//     await waitFor(() => {
//     expect(screen.getByText('Login')).toBeInTheDocument();
//   });
// });

// // test('shows error on failed signup', async () => {

// // });
