import "@testing-library/jest-dom";
import { TextEncoder, TextDecoder } from "util";

global.TextEncoder = TextEncoder as any;
global.TextDecoder = TextDecoder as any;

global.ResizeObserver = class {
    observe() {}
    unobserve() {}
    disconnect() {}
};
