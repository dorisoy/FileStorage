import { User } from './user';

export interface StorageItem {
    id?: string;
    displayName: string;
    extension: string;
    isFolder: boolean;
    isRecycled: boolean;
    user: User;
    userId: string;
    createdOn: Date;
}
