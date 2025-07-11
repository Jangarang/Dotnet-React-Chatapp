import { HubConnectionBuilder } from "@microsoft/signalr";


const connection = new HubConnectionBuilder()
	.withUrl('http://localhost:5023/chatHub')
	.withAutomaticReconnect()
	.build();

connection.start()
	.then(() => console.log('Connected to SignalR hub'))
	.catch(err => console.error('Connection failed:', err));



const Message = ({ message }: { message?: any }) => {
	const fromMe = message.fromMe;
	const chatClass = fromMe ? "chat-end" : "chat-start";
	const img = fromMe
		? "https://avatar.iran.liara.run/public/boy?username=johndoe"
		: "https://avatar.iran.liara.run/public/boy?username=janedoe";

	const bubbleBg = fromMe ? "bg-blue-500" : "";
	connection.on("ReceiveMessage", (user, message) => {
 	 	console.log(`${user}: ${message}`);
	});
	return (
		<div className={`chat ${chatClass}`}>
			<div className='hidden md:block chat-image avatar'>
				<div className='w-6 md:w-10 rounded-full'>
					<img alt='Tailwind CSS chat bubble component' src={img} />
				</div>
			</div>
			<p className={`chat-bubble text-white ${bubbleBg} text-sm md:text-md`}>{message.body}</p>
			<span className='chat-footer opacity-50 text-xs flex gap-1 items-center text-white'>22:59</span>
		</div>
	);
};
export default Message;